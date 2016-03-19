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
    class SqlReservationRepository : IReservationRepository
    {
        #region Queries

        private const string GetReservationsByDateQuery = @"SELECT * FROM tblReservation res 
                                                        WHERE (datediff(day, @dateTime, res.DateIn) = 0);";

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

        #endregion
    }
}
