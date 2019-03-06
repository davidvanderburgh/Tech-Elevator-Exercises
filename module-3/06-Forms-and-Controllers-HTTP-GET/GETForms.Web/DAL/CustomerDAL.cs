using GETForms.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private string connectionString;

        public CustomerDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Searches for customers.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <returns></returns>
        public IList<Customer> SearchForCustomers(string search, string sortBy)
        {
            IList<Customer> customers = new List<Customer>();

            string customerSearchSql =
                @"SELECT * FROM customer " +
                "WHERE first_name LIKE '%' + @search + '%' OR last_name LIKE '%' + @search + '%' " + 
                "ORDER BY " +
                " CASE @sortBy WHEN 'last_name' THEN last_name END, " +
                " CASE @sortBy WHEN 'email' THEN email END, " +
                " CASE @sortBy WHEN 'activebool' THEN activebool END";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(customerSearchSql, conn);
                cmd.Parameters.AddWithValue("@search", search);
                cmd.Parameters.AddWithValue("@sortBy", sortBy);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(MapRowToCustomer(reader));
                }
            }
            return customers;
        }
        private Customer MapRowToCustomer(SqlDataReader reader)
        {
            return new Customer()
            {
                Email = Convert.ToString(reader["email"]),
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"]),
                IsActive = Convert.ToBoolean(reader["activebool"])
            };
        }
    }
}
