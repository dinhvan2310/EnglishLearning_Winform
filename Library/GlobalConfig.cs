using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class GlobalConfig
    {
        public static GlobalConfig Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new GlobalConfig();
                return _Instance;
            }
            private set { }
        }

        private static GlobalConfig _Instance;

        private GlobalConfig()
        {
        }

        public string GenerateVerifyCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        public string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public string PathFileJS()
        {
            return Directory.GetCurrentDirectory() + @"\..\..\..\BLL\JS\";
        }

        public string PathFileResources()
        {
            return Directory.GetCurrentDirectory() + @"\..\..\Resources\";
        }
    }
}
