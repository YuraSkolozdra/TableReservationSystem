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
    public class SqlCustomerRepository : SqlBaseRepository, ICustomerRepository
    {
        #region Queries

        private const string GetAllCustomersQuery = "SELECT Id, FirstName, LastName, Phone FROM tblCustomer;";

        #endregion        

        #region Constructors

        public SqlCustomerRepository(string connectionString) : base(connectionString)
        {
        }

        #endregion

        #region ICustomerRepository

        public IEnumerable<Customer> SellectAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = GetAllCustomersQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var customers = new List<Customer>();
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            string firstName = (string)reader["FirstName"];
                            string lastName = (string)reader["LastName"];
                            string phone = (string)reader["Phone"];
                            customers.Add(new Customer() { Id = id, FirstName = firstName, LastName = lastName, Phone = phone });
                        }
                        return customers;
                    }
                }
            }
        }

        #endregion
    }
}
