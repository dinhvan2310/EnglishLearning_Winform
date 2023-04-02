using Mysqlx.Session;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace BLL.Components
{
    public class Validator
    {
        public bool CheckUsername(string username)
        {
            string regex = "^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$";
            return Regex.IsMatch(username, regex);
        }

        public bool CheckPassword(string pwd)
        {
            string regex = @"^\w{8,}$";
            return Regex.IsMatch(pwd, regex);
        }

        public bool CheckEmail(string email)
        {
            string regex = @"^[\w-\ .]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, regex);
        }
        public DateTime? CheckDate(string date)
        {
            //mon/day/year
            string regex = @"^[0-9]{1,2}\/[0-9]{1,2}\/[0-9]{4}$";

            int day, mon, year;
            DateTime dateTime = new DateTime();

            try
            {
                if (Regex.IsMatch(date, regex))
                {

                    Regex r = new Regex(@"^(?<mon>[0-9]{1,2})\/(?<day>[0-9]{1,2})\/(?<year>[0-9]{4})$");
                    foreach (Match item in r.Matches(date))
                    {
                        day = Convert.ToInt32(item.Groups["day"].ToString());
                        mon = Convert.ToInt32(item.Groups["mon"].ToString());
                        year = Convert.ToInt32(item.Groups["year"].ToString());
                        dateTime = new DateTime(year, mon, day);
                    }

                    return dateTime;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
