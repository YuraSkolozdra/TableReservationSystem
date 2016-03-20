using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.Entities;
using TRS.Repositories.Abstract;

namespace TRS.Repositories.Concrete
{
    public class SqlReservationRepository : IReservationRepository
    {
        #region Queries

        //TODO: Edit query
        private const string GetReservationsByDateQuery = @"SELECT * FROM tblReservation res 
                                                        WHERE (datediff(day, @dateTime, res.DateIn) = 0);";

        private const string GetCountOfResOnDateQuery = @"SELECT COUNT(res.Id) AS CountOfRes FROM tblReservation res 
                                                        WHERE (DATEDIFF(day, res.dateIn, @reservationDate) = 0);";

        private const string GetTotalGuestsOnDateQuery = @"SELECT SUM(tab.CountOfSeats) AS TotalGuests FROM tblReservation res 
	                                                        JOIN tblTable tab ON res.TableId = tab.Id
	                                                            WHERE (DATEDIFF(day, res.dateIn, @reservationDate) = 0);";

        #endregion

        #region Private Fields

        private readonly string _connectionString;

        #endregion

        #region Constructors

        public SqlReservationRepository(string connectionString)
        {
            _connectionString = connectionString;
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
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = GetReservationsByDateQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var reservations = new List<Reservation>();
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            decimal rate = (decimal)reader["Rate"];
                            int countOfSeats = (int)reader["CountOfSeats"];
                            //tables.Add(new Table() { Id = id, Rate = rate, CountOfSeats = countOfSeats });
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

        public int GetCountOfReservationOnDate(DateTime reservationDate)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = GetCountOfResOnDateQuery;
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

        #endregion
    }
}
