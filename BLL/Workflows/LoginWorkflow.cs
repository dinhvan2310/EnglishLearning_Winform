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
using Library;
using BLL.TransferObjects;

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

        public float CurrentOnlineHour
        {
            get
            {
                return (float)((DateTime.Now - _IniOnlineTime).TotalSeconds / 3600.0f);
            }
            private set { }
        }

        private int _UserID;

        private AccountManager _AccountManager;
        private EmailManager _EmailManager;
        private Validator _Validator;
        private PackageManager _PackageManager;
 
        private static LoginWorkflow _Instance;

        private string _Key = "2giotoitaigoccayda";
        private bool _FirstTimeLogged = false;
        private DateTime _IniOnlineTime;


        private LoginWorkflow()
        {
            _UserID = -1;

            _AccountManager = new AccountManager();
            _EmailManager = new EmailManager();
            _Validator = new Validator();
            _PackageManager = new PackageManager();

            _IniOnlineTime = DateTime.Now;
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
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_Key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(_Key);

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
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_Key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(_Key);

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
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "RememberMeLogin.json";
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
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "RememberMeLogin.json";
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
        public void HasAchievedGoal()
        {
            DetailedInformation detail = GetAccountDetail();
            _AccountManager.UpdateDetailInformation(
                _UserID,
                new DetailedInformation()
                {
                    AchievedGoal = true,
                    NumberOfConsecutiveDay = detail.NumberOfConsecutiveDay,
                    Balance = detail.Balance
                });
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
        public bool IsFirstTimeLogged()
        {
            return _FirstTimeLogged;
        }

        public bool IsAdmin()
        {
            return GetAccount().TypeID == 5;
        }

        public bool IsPremium()
        {            
            return _UserID != -1 && _PackageManager.GetUserPacketInfo(_UserID, "Premium")?.DueDate > DateTime.Now;
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
                    if (dbContext.Account.SingleOrDefault(i => i.UserName == userName) == null)
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
                    Account account = dbContext.Account.SingleOrDefault(i => i.UserName == userName);
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

                            SetupAccount();
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

        private void SetupAccount()
        {
            // update account
            int yesterdayID = Convert.ToInt32(
                        DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0)).ToString("yyyyMMdd"));
            InformationPerDay yesterdayIPD = _AccountManager.GetLearningStat_ByID(_UserID, yesterdayID);
            InformationPerDay currentIPD = _AccountManager.GetLearningStat_ByID(_UserID,
                Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")));

            DetailedInformation detail = GetAccountDetail();
            _FirstTimeLogged = currentIPD == null;
            if (yesterdayIPD == null) // not online yesterday
            {
                _AccountManager.UpdateDetailInformation(_UserID, new DetailedInformation()
                {
                    NumberOfConsecutiveDay = 0,
                    Balance = detail.Balance,
                    AchievedGoal = detail.AchievedGoal
                });
            }
            else if (currentIPD == null) // first time login of day
            {
                _AccountManager.UpdateDetailInformation(_UserID, new DetailedInformation()
                {
                    NumberOfConsecutiveDay = detail.NumberOfConsecutiveDay + 1,
                    Balance = detail.Balance,
                    AchievedGoal = false
                });
            }
            _AccountManager.UpdateLearningStat(_UserID, 0, 0);
        }

        // auto login usage
        public bool Login()
        {
            try
            {
                string fileFullPath = GlobalConfig.Instance.PathFileJS() + "RememberMeLogin.json";
                string json = File.ReadAllText(fileFullPath);
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                string userNameHash = jsonObj["UserName"].ToString();
                string passwordHash = jsonObj["Password"].ToString();

                if (userNameHash == "" || passwordHash == "")
                    return false;

                string user = Decrypt(userNameHash);
                string password = Decrypt(passwordHash);
                using (var dbContext = new DictionaryContext())
                {
                    Account account = dbContext.Account.SingleOrDefault(i => i.UserName == user);
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

                            SetupAccount();
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

        public void UpdateLearningStat(float learnedHour, int learnedWord)
        {
            _AccountManager.UpdateLearningStat(_UserID, learnedHour, learnedWord);
        }

        public int GetNumberOfLearnedDay()
        {
            return _AccountManager.GetLearningStat_All_ByUID(_UserID).Count();
        }

        public int GetNumberOfLearnedWord()
        {
            int result = 0;
            _AccountManager.GetLearningStat_All_ByUID(_UserID).ForEach(item =>
            {
                result += item.NumberOfLearnedWord;
            });

            return result;
        }

        public float GetNumberOfLearnedHour()
        {
            float result = 0;
            _AccountManager.GetLearningStat_All_ByUID(_UserID).ForEach(item =>
            {
                result += item.OnlineHour;
            });

            return result;
        }

        public float GetNumberOfLearnedHour_Today()
        {
            int todayID = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
            return _AccountManager.GetLearningStat_ByID(_UserID, todayID).OnlineHour + CurrentOnlineHour;
        }

        public float GetNumberOfLearnedMinute_Today()
        {
            return GetNumberOfLearnedHour_Today() * 60.0f;
        }

        public void AdjustBalance(int adjustAmount)
        {
            DetailedInformation detail = GetAccountDetail();
            _AccountManager.UpdateDetailInformation(_UserID, new DetailedInformation()
            {
                NumberOfConsecutiveDay = detail.NumberOfConsecutiveDay,
                Balance = detail.Balance + adjustAmount,
                AchievedGoal = detail.AchievedGoal
            });

        }

        public bool CheckExistGmail(string email, string username)
        {
            using(var db = new DictionaryContext())
            {
                if(db.Account.SingleOrDefault(p => p.Email == email && p.UserName == username ) != null)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdatePassword(string username, string newPass)
        {
            using(var db = new DictionaryContext())
            {
                Account acc = db.Account.SingleOrDefault(p => p.UserName == username);
                if(acc != null)
                {
                    acc.Password = CreateMD5(newPass);
                    db.Entry(acc.DetailedInformation).State = System.Data.Entity.EntityState.Unchanged;
                    db.SaveChanges();
                    return true;
                }
              
            }
            return false;
        }
    }
}
