using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string cs = @"server=localhost;userid=user;password=password;database=products; SSL Mode=None";

        using (var con = new MySqlConnection(cs))
        {
            con.Open();
            Console.WriteLine($"MySQL version : {con.ServerVersion}");
        }
    }
}
