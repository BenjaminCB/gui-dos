using MySql.Data.MySqlClient;

namespace myWebApp.Services
{
    public abstract class SqlService
    {
        public string ConnectionString { get; private set; }

        public MySqlConnection Con { get; set; }

        public SqlService(string connectionString)
        {
            ConnectionString = connectionString;
            Con = new MySqlConnection(ConnectionString);
            Con.Open();
        }

        ~SqlService()
        {
            Con.Close();
        }
    }
}
