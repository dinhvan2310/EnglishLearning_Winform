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
        /// <summary>
        /// Kiểm tra định dạng của UserName
        /// - Bao gồm a-z, A-Z, 0-9, ., _, 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool CheckUsername(string username)
        {
            string regex = "^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$";
            return Regex.IsMatch(username, regex);
        }

        /// <summary>
        /// Kiểm tra định dạng password
        /// - Bao gồm a-z, A-Z, _
        /// - Có từ 8 kí tự trỏ lên
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool CheckPassword(string pwd)
        {
            string regex = @"^\w{8,}$";
            return Regex.IsMatch(pwd, regex);
        }

        /// <summary>
        /// Kiểm tra định dạng email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckEmail(string email)
        {
            string regex = @"^[\w-\ .]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, regex);
        }

        /// <summary>
        /// Kiểm tra định dạng ngày tháng
        /// - mm/dd/yyyy
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
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
                    Match item = new Regex(@"^(?<mon>[0-9]{1,2})\/(?<day>[0-9]{1,2})\/(?<year>[0-9]{4})$").Match(date);
                    day = Convert.ToInt32(item.Groups["day"].ToString());
                    mon = Convert.ToInt32(item.Groups["mon"].ToString());
                    year = Convert.ToInt32(item.Groups["year"].ToString());
                    dateTime = new DateTime(year, mon, day);
                    return dateTime;
                }
                else
                {
                    return null;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

    }
}
