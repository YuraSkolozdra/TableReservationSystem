using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TRS.Entities;
using TRS.Repositories.Abstract;

namespace TRS.Repositories.Concrete
{
    public class SqlTableRepository : SqlBaseRepository, ITableRepository
    {
        #region Queries

        private const string GetByIdQuery = @"SELECT tab.Id, tab.Rate, tab.CountOfSeats, 
                                                loc.Id AS LocationId, loc.Name AS LocationName 
                                                    FROM tblTable tab 
                                                    JOIN tblLocation loc 
                                                    ON tab.LocationId = loc.Id 
                                                        WHERE tab.Id = @tableId;";

        private const string SelectAllQuery = @"SELECT tab.Id, tab.Rate, tab.CountOfSeats,
                                                    loc.Id, loc.Name 
                                                    FROM tblTable tab
                                                    JOIN tblLocation loc
                                                    ON tab.LocationId = loc.Id
                                                    ORDER BY Rate;";

        private const string GetBySeatsQuery = @"SELECT tab.Id, tab.Rate, tab.CountOfSeats, 
                                                    loc.Id AS LocationId, loc.Name AS LocationName 
                                                        FROM tblTable tab 
                                                        JOIN tblLocation loc 
                                                        ON tab.LocationId = loc.Id 
                                                        WHERE tab.CountOfSeats = @countOfSeats;";

        private const string GetMaxCountOfSeatsQuery = @"SELECT MAX(CountOfSeats) AS MaxCountOfSeats FROM tblTable;";

        private const string GetAvailableTablesQuery = "sp_GetTablesByDateAndSeats";

        #endregion

        #region Constructors

        public SqlTableRepository(string connectionString) : base(connectionString)
        {
        }

        #endregion

        #region ITableRepository

        public IEnumerable<Table> SellectAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = SelectAllQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var tables = new List<Table>();
                        while (reader.Read())
                        {
                            tables.Add(new Table()
                            {
                                Id = (int)reader["Id"],
                                Rate = (decimal)reader["Rate"],
                                CountOfSeats = (int)reader["CountOfSeats"],
                                Location = new Location()
                                {
                                    Id = (int)reader["LocationId"],
                                    Name = (string)reader["LocationName"]
                                }
                            });
                        }
                        return tables;
                    }
                }
            }
        }

        public IEnumerable<Table> GetAvailableTables(DateTime dateIn, DateTime dateOut, int countOfSeats)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = GetAvailableTablesQuery;
                    command.Parameters.AddWithValue("@dateIn", dateIn);
                    command.Parameters.AddWithValue("@dateOut", dateOut);
                    command.Parameters.AddWithValue("@countOfSeats", countOfSeats);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var tables = new List<Table>();
                        while (reader.Read())
                        {
                            tables.Add(new Table()
                            {
                                Id = (int)reader["Id"],
                                Rate = (decimal)reader["Rate"],
                                CountOfSeats = (int)reader["CountOfSeats"],
                                Location = new Location()
                                {
                                    Id = (int)reader["LocationId"],
                                    Name = (string)reader["LocationName"]
                                }
                            });
                        }
                        return tables;
                    }
                }
            }
        }

        public Table GetTableById(int tableId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = GetByIdQuery;
                    command.Parameters.AddWithValue("@tableId", tableId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Table table = null;
                        if (reader.Read())
                        {
                            table = new Table()
                            {
                                Id = (int)reader["Id"],
                                Rate = (decimal)reader["Rate"],
                                CountOfSeats = (int)reader["CountOfSeats"],
                                Location = new Location()
                                {
                                    Id = (int)reader["LocationId"],
                                    Name = (string)reader["LocationName"]
                                }
                            };
                        }
                        return table;
                    }
                }
            }
        }

        public int GetMaxCountOfSeats()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = GetMaxCountOfSeatsQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int? result = null;
                        if (reader.Read())
                        {
                            result = reader["MaxCountOfSeats"] as int?;
                        }
                        return result ?? 0;
                    }
                }
            }
        }

        #endregion
    }
}
