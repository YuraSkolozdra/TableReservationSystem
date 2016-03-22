using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TRS.Entities;
using TRS.Repositories.Abstract;

namespace TRS.Repositories.Concrete
{
    public class SqlReservationRepository : SqlBaseRepository, IReservationRepository
    {
        #region Queries

        private const string GetReservationsByDateQuery = "sp_GetReservationsByDate";

        private const string GetAllReservationsByCustomerPhoneQuery = "sp_GetAllReservationsByCustomerPhone";


        private const string GetCountOfResByDateQuery = @"SELECT COUNT(res.Id) AS CountOfRes 
                                                            FROM tblReservation res 
                                                                WHERE (DATEDIFF(day, res.dateIn, @reservationDate) = 0);";

        private const string GetTotalGuestsOnDateQuery = @"SELECT SUM(tab.CountOfSeats) AS TotalGuests 
                                                            FROM tblReservation res 
	                                                        JOIN tblTable tab 
                                                            ON res.TableId = tab.Id
	                                                            WHERE (DATEDIFF(day, res.dateIn, @reservationDate) = 0);";

        private const string spGetCostOfReservationQuery = "sp_GetCostOfReservation";

        private const string spReserveTable = "sp_ReserveTable";

        private const string spCancelReservationByIdQuery = "sp_CancelReservationById";

        #endregion        

        #region Constructors

        public SqlReservationRepository(string connectionString) : base(connectionString)
        {
        }

        #endregion

        #region IReservationRepository

        public IEnumerable<Reservation> GetReservationsByDate(DateTime reservationDate, int reservationStatus = 1)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = GetReservationsByDateQuery;
                    command.Parameters.AddWithValue("@reservationDate", reservationDate);
                    command.Parameters.AddWithValue("@reservationStatus", reservationStatus);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var reservations = new List<Reservation>();
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            var table = new Table()
                            {
                                Id = (int)reader["TableId"],
                                Rate = (decimal)reader["Rate"],
                                CountOfSeats = (int)reader["CountOfSeats"],
                                Location = new Location()
                                {
                                    Id = (int)reader["LocationId"],
                                    Name = (string)reader["LocationName"]
                                }
                            };
                            var customer = new Customer()
                            {
                                Id = (int)reader["CustomerId"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Phone = (string)reader["Phone"]
                            };
                            var reservation = new Reservation()
                            {
                                Id = id,
                                Table = table,
                                Customer = customer,
                                DateIn = (DateTime)reader["DateIn"],
                                DateOut = (DateTime)reader["DateOut"],
                                Status = (int)reader["Status"],
                                Cost = (decimal)reader["Cost"],
                                UserId = (int)reader["UserId"]
                            };
                            reservations.Add(reservation);
                        }
                        return reservations;
                    }
                }
            }
        }

        public IEnumerable<Reservation> GetReservationsByCustomerPhone(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = GetAllReservationsByCustomerPhoneQuery;
                    command.Parameters.AddWithValue("@customerPhone", customer.Phone);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var reservations = new List<Reservation>();
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            var table = new Table()
                            {
                                Id = (int)reader["TableId"],
                                Rate = (decimal)reader["Rate"],
                                CountOfSeats = (int)reader["CountOfSeats"],
                                Location = new Location()
                                {
                                    Id = (int)reader["LocationId"],
                                    Name = (string)reader["LocationName"]
                                }
                            };
                            var customerRes = new Customer()
                            {
                                Id = (int)reader["CustomerId"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Phone = (string)reader["Phone"]
                            };
                            var reservation = new Reservation()
                            {
                                Id = id,
                                Table = table,
                                Customer = customerRes,
                                DateIn = (DateTime)reader["DateIn"],
                                DateOut = (DateTime)reader["DateOut"],
                                Status = (int)reader["Status"],
                                Cost = (decimal)reader["Cost"],
                                UserId = (int)reader["UserId"]
                            };
                            reservations.Add(reservation);
                        }
                        return reservations;
                    }
                }
            }
        }

        public int GetCountOfReservationByDate(DateTime reservationDate)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = GetCountOfResByDateQuery;
                    command.Parameters.AddWithValue("@reservationDate", reservationDate);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int? result = null;
                        if (reader.Read())
                        {
                            result = reader["CountOfRes"] as int?;
                        }
                        return result ?? 0;
                    }
                }
            }
        }

        public int GetTotalGuestsOnDate(DateTime reservationDate)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = GetTotalGuestsOnDateQuery;
                    command.Parameters.AddWithValue("@reservationDate", reservationDate);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int? result = null;
                        if (reader.Read())
                        {
                            result = reader["TotalGuests"] as int?;
                        }
                        return result ?? 0;
                    }
                }
            }
        }

        public decimal GetCostOfReservation(Table table, DateTime dateIn, DateTime dateOut)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetCostOfReservationQuery;
                    command.Parameters.AddWithValue("@tableId", table.Id);
                    command.Parameters.AddWithValue("@dateIn", dateIn);
                    command.Parameters.AddWithValue("@dateOut", dateOut);

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@cost";
                    param.SqlDbType = SqlDbType.Decimal;
                    param.Direction = ParameterDirection.Output;

                    command.Parameters.Add(param);

                    command.ExecuteNonQuery();

                    return (decimal)command.Parameters["@cost"].Value;
                }
            }
        }

        public int ReserveTable(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spReserveTable;
                    command.Parameters.AddWithValue("@firstName", reservation.Customer.FirstName);
                    command.Parameters.AddWithValue("@lastName", reservation.Customer.LastName);
                    command.Parameters.AddWithValue("@phone", reservation.Customer.Phone);
                    command.Parameters.AddWithValue("@dateIn", reservation.DateIn);
                    command.Parameters.AddWithValue("@dateOut", reservation.DateOut);
                    command.Parameters.AddWithValue("@tableId", reservation.Table.Id);
                    command.Parameters.AddWithValue("@userId", reservation.UserId);

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@reservationId";
                    param.SqlDbType = SqlDbType.Int;
                    param.Direction = ParameterDirection.Output;

                    command.Parameters.Add(param);

                    command.ExecuteNonQuery();

                    return (int)command.Parameters["@reservationId"].Value;
                }
            }
        }

        public bool CancelReservationById(int reservationId, int userId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = GetReservationsByDateQuery;
                    command.Parameters.AddWithValue("@reservationId", reservationId);
                    command.Parameters.AddWithValue("@userId", userId);

                    return command.ExecuteNonQuery() == 0 ? true : false;
                }
            }

        }

        #endregion
    }
}
