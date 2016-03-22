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
                            user = new User()
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Login = (string)reader["Login"],
                                Disabled = (bool)reader["Disabled"]
                            };                            
                        }
                        return user;
                    }
                }
            }
        }

        #endregion
    }
}
