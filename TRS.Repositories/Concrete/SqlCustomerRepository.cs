using System.Collections.Generic;
using System.Data.SqlClient;
using TRS.Entities;
using TRS.Repositories.Abstract;

namespace TRS.Repositories.Concrete
{
    public class SqlCustomerRepository : SqlBaseRepository, ICustomerRepository
    {
        #region Queries

        private const string GetAllCustomersQuery = "SELECT Id, FirstName, LastName, Phone FROM tblCustomer;";

        private const string GetCustomerByPhoneQuery = @"SELECT Id, FirstName, LastName, Phone 
                                                            FROM tblCustomer 
                                                            WHERE Phone LIKE @phone;";


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

        public Customer GetCustomerByPhone(string phone)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = GetCustomerByPhoneQuery;
                    command.Parameters.AddWithValue("@phone", phone);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Customer customer = null; 
                        while (reader.Read())
                        {
                            customer = new Customer();
                            customer.Id = (int)reader["Id"];
                            customer.FirstName = (string)reader["FirstName"];
                            customer.LastName = (string)reader["LastName"];
                            customer.Phone = (string)reader["Phone"];
                        }
                        return customer;
                    }
                }
            }
        }

        #endregion
    }
}
