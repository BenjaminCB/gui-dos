using BlazorApp.Models;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BlazorApp.Services
{
    public class SqlProductService : SqlService, ISqlService<Product>
    {
        public SqlProductService(string connectionString) : base(connectionString) {}
        private string table { get; set; } = "product";

        public List<Product> GetAll()
        {
            // create command
            string query = "SELECT * FROM " + table;
            MySqlCommand cmd = new MySqlCommand(query, Con);

            // read data
            using MySqlDataReader reader = cmd.ExecuteReader();
            return Converter(reader);
        }

        private List<Product> Converter(MySqlDataReader reader)
        {

            List<Product> products = new List<Product>();

            while (reader.Read())
            {

                products.Add(new Product()
                {
                    Title = reader["title"].ToString(),
                    Description = reader["description"].ToString(),
                    Image = reader["image"].ToString()
                });
            }

            return products;
        }
    }
}
