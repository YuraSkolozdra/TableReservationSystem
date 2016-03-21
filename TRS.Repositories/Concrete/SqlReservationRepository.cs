using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.Entities;
using TRS.Repositories.Abstract;

namespace TRS.Repositories.Concrete
{
    public class SqlReservationRepository : SqlBaseRepository, IReservationRepository
    {
        #region Queries

        //TODO: Edit query
        private const string GetReservationsByDateQuery = "sp_GetReservationsByDate";

        private const string GetCountOfResByDateQuery = @"SELECT COUNT(res.Id) AS CountOfRes FROM tblReservation res 
                                                        WHERE (DATEDIFF(day, res.dateIn, @reservationDate) = 0);";

        private const string GetTotalGuestsOnDateQuery = @"SELECT SUM(tab.CountOfSeats) AS TotalGuests FROM tblReservation res 
	                                                        JOIN tblTable tab ON res.TableId = tab.Id
	                                                            WHERE (DATEDIFF(day, res.dateIn, @reservationDate) = 0);";

        private const string spReserveTable = "sp_ReserveTable";

        #endregion        

        #region Constructors

        public SqlReservationRepository(string connectionString) : base(connectionString)
        {
        }

        #endregion


        #region IReservationRepository

        /// <summary>
        /// Search all reservation for a specific date
        /// </summary>
        /// <param name="reservationDate"></param>
        /// <returns>Collection of reservation</returns>
        public IEnumerable<Reservation> GetReservationsByDate(DateTime reservationDate)
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


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var reservations = new List<Reservation>();
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            int tableId = (int)reader["TableId"];
                            decimal rate = (decimal)reader["Rate"];
                            int countOfSeats = (int)reader["CountOfSeats"];
                            int locationId = (int)reader["LocationId"];
                            string locationName = (string)reader["LocationName"];
                            int customerId = (int)reader["CustomerId"];
                            string firstName = (string)reader["FirstName"];
                            string lastName = (string)reader["LastName"];
                            string phone = (string)reader["Phone"];
                            DateTime dateIn = (DateTime)reader["DateIn"];
                            DateTime dateOut = (DateTime)reader["DateOut"];
                            int status = (int)reader["Status"];
                            decimal cost = (decimal)reader["Cost"];
                            int userId = (int)reader["UserId"];
                            var location = new Location() { Id = locationId, Name = locationName };
                            var table = new Table() { Id = tableId, Rate = rate, CountOfSeats = countOfSeats, Location = location };
                            var customer = new Customer() { Id = customerId, FirstName = firstName, LastName = lastName, Phone = phone };
                            var reservation = new Reservation() { Id = id, Table = table, Customer = customer, DateIn = dateIn, DateOut = dateOut, Status = status, Cost = cost, UserId = userId };
                            reservations.Add(reservation);
                        }
                        return reservations;
                    }
                }
            }
        }

        public IEnumerable<Reservation> SellectAll()
        {
            throw new NotImplementedException();
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

        public int ReserveTable(string firstName, string lastName, string phone,
            DateTime dateIn, DateTime dateOut, int tableId, int userId)
        {
            int reservationId = -1;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spReserveTable;
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@dateIn", dateIn);
                    command.Parameters.AddWithValue("@dateOut", dateOut);
                    command.Parameters.AddWithValue("@tableId", tableId);
                    command.Parameters.AddWithValue("@userId", userId);

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@reservationId";
                    param.SqlDbType = SqlDbType.Int;
                    param.Direction = ParameterDirection.Output;

                    command.Parameters.Add(param);

                    command.ExecuteNonQuery();

                    reservationId = (int)command.Parameters["@reservationId"].Value;

                    return reservationId;
                }
            }
        }

        #endregion
    }
}
