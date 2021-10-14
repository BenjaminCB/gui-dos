using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace myWebApp.Services
{
    interface ISqlService<T>
    {
        MySqlConnection Con { get; set; }

        List<T> GetAll();
    }
}
