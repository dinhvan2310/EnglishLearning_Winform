using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace PBLLibrary.Database
{
    public class DatabaseConnection
    {
        private static readonly string _MySqlConnectionString = "server=localhost;user id=root;password=Thonns178;database=wn_pro_mysql;port=3306";
        private static MySqlConnection _DatabaseConnection;

        public static void Init()
        {
            _DatabaseConnection = new MySqlConnection(_MySqlConnectionString);


        }

        public static MySqlDataReader Query(string query)
        {
            MySqlCommand queryCommand = new MySqlCommand(query, _DatabaseConnection);
            queryCommand.CommandTimeout = 60;

            if (_DatabaseConnection.State == System.Data.ConnectionState.Open)
                _DatabaseConnection.Close();

            try
            {
                _DatabaseConnection.Open();

                MySqlDataReader reader = queryCommand.ExecuteReader();

                return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection To Database Failed. Log: " + ex.Message + " (" + ex.Number + ")");
            }

            return null;
        }
    }
}
