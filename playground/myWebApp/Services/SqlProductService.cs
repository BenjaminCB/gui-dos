using MySql.Data.MySqlClient;
using myWebApp.Models;
using System.Collections.Generic;

namespace myWebApp.Services
{
    public class SqlProductService
    {
        public string ConnectionString { get; private set; }

        private MySqlConnection Con { get; set; }

        public SqlProductService(string connectionString)
        {
            ConnectionString = connectionString;
            Con = new MySqlConnection(ConnectionString);
            Con.Open();
        }

        ~SqlProductService()
        {
            Con.Close();
        }

        public List<Product> GetProducts()
        {
            List<Product> Products = new List<Product>();
            string Query = "SELECT * FROM product";
            MySqlCommand Cmd = new MySqlCommand(Query, Con);

            using (MySqlDataReader Reader = Cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Products.Add(new Product()
                    {
                        Title = Reader["title"].ToString(),
                        Description = Reader["description"].ToString(),
                        Image = Reader["image"].ToString()
                    });
                }
            }

            return Products;
        }
    }
}
