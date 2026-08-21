using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace Comedor_Asados_La_Flaca
{


    public static class DbConfig
    {
        private static readonly IConfigurationRoot config;

        static DbConfig()
        {
            config = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
      .Build();
        }

        // Aquí usás el mismo nombre que pusiste en tu appsettings.json
        public static string ConnectionString =>
            config.GetConnectionString("ConexionDB");


    }
}
