using BlazorApp.Models;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BlazorApp.Services
{
    public class SqlOrderService : SqlService, ISqlService<Order>
    {
        public SqlOrderService(string connectionString) : base(connectionString) {}
        private string table { get; set; } = "order";

        public List<Order> GetAll()
        {
            string query = "SELECT * FROM " + table;
            MySqlCommand cmd = new MySqlCommand(query, Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            return Converter(reader);
        }

        private List<Order> Converter(MySqlDataReader reader)
        {
            List<Order> orders = new List<Order>();

            while (reader.Read())
            {

                orders.Add(new Order()
                {
                    // TODO
                });
            }

            return orders;
        }
    }
}
