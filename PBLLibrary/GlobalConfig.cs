using PBLLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBLLibrary
{
    public static class GlobalConfig
    {
        public static MySQLConnector Connector { get; private set; }

        public static void InitializeConnection()
        {
            Connector = new MySQLConnector();
        }
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
