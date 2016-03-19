using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TRS.Entities;
using TRS.Repository.Abstract;

namespace TRS.Repository.Concrete
{
    public class SqlTableRepository : ITableRepository
    {
        #region Queries

        private const string PriceQuery = "SELECT Id, Rate, CountOfSeats FROM tblTable ORDER BY Rate;";
        private const string GetBySeatsQuery = @"SELECT tab.Id, tab.Rate, tab.CountOfSeats, loc.Id, loc.Name FROM tblTable tab JOIN tblLocation loc 
                                                    ON tab.LocationId = loc.Id WHERE tab.CountOfSeats = @countOfSeats;";

        #endregion

        #region Private fields

        private readonly string _connectionString;

        #endregion

        #region Constructors

        public SqlTableRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion

        #region ITableRepository

        public IEnumerable<Table> GetBySeats(int countOfSeats)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Table> SellectAll()
        {
            string priceQuery = "SELECT Id, Rate, CountOfSeats FROM tblTable ORDER BY Rate;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = priceQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var tables = new List<Table>();
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            decimal rate = (decimal)reader["Rate"];
                            int countOfSeats = (int)reader["CountOfSeats"];
                            tables.Add(new Table() { Id = id, Rate = rate, CountOfSeats = countOfSeats });
                        }
                        return tables;
                    }
                }
            }
        }

        #endregion
    }
}
