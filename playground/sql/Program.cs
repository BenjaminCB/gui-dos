using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string cs = @"server=localhost;userid=user;password=password;database=products; SSL Mode=None";

        var con = new MySqlConnection(cs);
        con.Open();
        Console.WriteLine($"MySQL version : {con.ServerVersion}");


        // var cmd = new MySqlCommand();
        // cmd.Connection = con;
        // cmd.CommandText = "INSERT INTO product VALUE('this', 'is', 'product')";
        // cmd.ExecuteNonQuery();


        // string sql = "INSERT INTO product VALUE(@title, @description, @image)";
        // var cmd = new MySqlCommand(sql, con);
        // cmd.Parameters.AddWithValue("@title", "this");
        // cmd.Parameters.AddWithValue("@description", "is");
        // cmd.Parameters.AddWithValue("@image", "product");
        // cmd.ExecuteNonQuery();

        string sql = "SELECT * FROM product";
        var cmd = new MySqlCommand(sql, con);

        using (MySqlDataReader rdr = cmd.ExecuteReader())
        {
            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));
            }
        }
    }
}
