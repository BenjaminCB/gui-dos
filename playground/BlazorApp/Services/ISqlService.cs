using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BlazorApp.Services
{
    interface ISqlService<T>
    {
        MySqlConnection Con { get; set; }

        List<T> GetAll();
    }
}
