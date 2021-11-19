using System;
using System.Collections.Generic;
using System.Linq;                          //Database Query
using System.Threading.Tasks;               //Memory Managment
using Microsoft.AspNetCore.Hosting;         //Blazor
using Microsoft.Extensions.Configuration;   //Configure Logging and Authentication
using Microsoft.Extensions.Hosting;         //Blazor WebAssemly
using Microsoft.Extensions.Logging;         //Actual Logging Extension

namespace gui_dos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
 