using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TRS.Entities;
using TRS.Repositories.Abstract;

namespace TRS.Repositories
{
    public class SqlUserRepository : SqlBaseRepository, IUserRepository
    {
        #region Queries

        private const string spGetUserByLoginQuery = "sp_GetUserByLogin";

        #endregion

        #region Constructors

        public SqlUserRepository(string connectionString) : base(connectionString)
        {
        }

        #endregion

        #region IUserRepository

        public User GetUserByLogin(string login, string passwordHash)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetUserByLoginQuery;
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        User user = null;
                        if (reader.Read())
                        {
                            user = new User();
                            user.Id = (int)reader["Id"];
                            user.FirstName = (string)reader["FirstName"];
                            user.LastName = (string)reader["LastName"];
                            user.Login = (string)reader["Login"];
                            user.Disabled = (bool)reader["Disabled"];
                        }
                        return user;
                    }
                }
            }
        }

        #endregion
    }
}
