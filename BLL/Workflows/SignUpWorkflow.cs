using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Components;
using EFramework;
using EFramework.Model;

namespace BLL.Workflows
{
    public class SignUpWorkflow
    {
        public static SignUpWorkflow Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SignUpWorkflow();
                }
                return _Instance;
            }
        }

        private int _UserID;

        private AccountManager _DataAccountAccess;
        private EmailManager _EmailManager;
        private Validator _Validator;
 
        private static SignUpWorkflow _Instance;

        private SignUpWorkflow()
        {
            _UserID = -1;

            _DataAccountAccess = new AccountManager();
            _EmailManager = new EmailManager();
            _Validator = new Validator();
        }


        private string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public bool SaveAccount(string name, bool gender, DateTime? ngaySinh, string userName, string password, string email)
        {
            password = CreateMD5(password);
            return _DataAccountAccess.SaveAccount(name, gender, ngaySinh, userName, password, email);
        }
        public void SendMessage(string desEmail, string subject, string body)
        {
            _EmailManager.SendMessage(desEmail, subject, body);
        }
        public bool CheckUsername(string username)
        {
            return _Validator.CheckUsername(username);
        }

        public bool CheckPassword(string pwd)
        {
            return _Validator.CheckPassword(pwd);
        }

        public bool CheckEmail(string email)
        {
            return _Validator.CheckEmail(email);
        }

        public DateTime? CheckDate(string date)
        {
            return _Validator.CheckDate(date);
        }

        /// <summary>
        /// Kiêm tra sự tồn tại của Account bằng UserName
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool CheckExsitAccount(string userName)
        {
            try
            {
                using (var dbContext = new DictionaryContext())
                {
                    if (dbContext.account.SingleOrDefault(i => i.UserName == userName) == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool Login(string userName, string password)
        {
            try
            {
                using (var dbContext = new DictionaryContext())
                {
                    Account account = dbContext.account.SingleOrDefault(i => i.UserName == userName);
                    if (account == null)
                    {
                        return false;
                    }
                    else
                    {
                        string pass = CreateMD5(password);
                        Console.WriteLine(pass);
                        Console.WriteLine(account.Password);
                        if (account.Password == pass)
                        {
                            _UserID = account.AccountID;
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}
