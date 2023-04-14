using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Components;
using EFramework;
using EFramework.Model;
using Newtonsoft.Json;
using PBLLibrary;


namespace BLL.Workflows
{
    public class LoginWorkflow
    {
        public static LoginWorkflow Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LoginWorkflow();
                }
                return _Instance;
            }
        }

        private int _UserID;

        private AccountManager _AccountManager;
        private EmailManager _EmailManager;
        private Validator _Validator;
 
        private static LoginWorkflow _Instance;

        private string key = "2giotoitaigoccayda";

        private LoginWorkflow()
        {
            _UserID = -1;

            _AccountManager = new AccountManager();
            _EmailManager = new EmailManager();
            _Validator = new Validator();
        }

        

        /// <summary>
        /// Mã hóa chuỗi có mật khẩu
        /// </summary>
        /// <param name="toEncrypt">Chuỗi cần mã hóa</param>
        /// <returns>Chuỗi đã mã hóa</returns>
        public string Encrypt(string toEncrypt)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// Giản mã
        /// </summary>
        /// <param name="toDecrypt">Chuỗi đã mã hóa</param>
        /// <returns>Chuỗi giản mã</returns>
        public string Decrypt(string toDecrypt)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public void DisableRememberMeLogin()
        {
            string fileFullPath = GlobalConfig.Instance.PathFileRememberMeLogin() + "RememberMeLogin.json";
            string json = File.ReadAllText(fileFullPath);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            jsonObj = new
            {
                UserName = "",
                Password = "",
            };

            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(fileFullPath, output);
        }

        public void ActiveRememberMeLogin(string UserID, string Password)
        {
            string fileFullPath = GlobalConfig.Instance.PathFileRememberMeLogin() + "RememberMeLogin.json";
            string json = File.ReadAllText(fileFullPath);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);

            jsonObj = new
            {
                UserName = Encrypt(UserID),
                Password = Encrypt(Password),
            };
            
            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(fileFullPath, output);
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

        public bool SaveAccount(Account account)
        {
            account.Password = CreateMD5(account.Password);
            return _AccountManager.SaveAccount(account);
        }
        public void UpdateAccount(Account account)
        {
            account.AccountID = _UserID;
            _AccountManager.UpdateAccount(account);
        }
        public Account GetAccount()
        {
            return _AccountManager.GetAccount(_UserID);
        }
        public DetailedInformation GetAccountDetail()
        {
            return _AccountManager.GetAccountDetail(_UserID);
        }
        public bool IsLoggedIn()
        {
            return _UserID != -1;
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

                            _AccountManager.UpdateLearningStat(_UserID, 0, 0);
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
