using BlazorApp.Models;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BlazorApp.Services
{
    public class SqlEmployeeService : SqlService, ISqlService<Employee>
    {
        public SqlEmployeeService(string connectionString) : base(connectionString) {}
        private string table { get; set; } = "product";

        public List<Employee> GetAll()
        {
            string query = "SELECT * FROM " + table;
            MySqlCommand cmd = new MySqlCommand(query, Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            return Converter(reader);
        }

        private List<Employee> Converter(MySqlDataReader reader)
        {

            List<Employee> employees = new List<Employee>();

            while (reader.Read())
            {

                employees.Add(new Employee()
                {
                    // TODO
                });
            }

            return employees;
        }
    }
}
