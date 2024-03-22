using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Utils
{
    internal class DbUtils
    {
        private static IConfiguration _configuration;

        static DbUtils()
        {
            getAppSettings();
        }

        static void getAppSettings()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            _configuration = builder.Build();
        }

        public static string GetConnection() {
            return _configuration.GetConnectionString("LocalConnectionString");
        
        }

    }
}
