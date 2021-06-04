using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace CinemaWork.Configurations
{
    public static class ConfigHelper
    {
        public static IConfiguration Configuration { get; set; }

        public static string CimenaName { get { return Configuration["CinemaName"]; } }

        public static string ConnectionString { get { return Configuration["ConnectionString"]; } }
    }
}
