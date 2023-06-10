using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using BLL.TransferObjects;
using BLL.Workflows;
using EFramework;
using EFramework.Model;
using Library;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;

namespace BLL.Components
{
    public class AccountManager
    {

        
        public bool SaveAccount(Account account)
        {
            try
            {
                using (var dbContext = new DictionaryContext())
                {
                    account.TypeID = 4; // User type ID
                    

                    dbContext.Account.Add(account);
                    dbContext.SaveChanges();
                }
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void UpdateAccount(Account account)
        {
            using (var dbContext = new DictionaryContext())
            {
                Account old = dbContext.Account.SingleOrDefault(p => p.AccountID == account.AccountID);

                old.Name = account.Name;
                old.Email = account.Email;
                old.BirthDate = account.BirthDate;
                old.Gender = account.Gender;

                dbContext.Entry(old.DetailedInformation).State = EntityState.Modified;

                dbContext.SaveChanges();
            }
        }

        public Account GetAccount(int accountID)
        {
            using (var dbContext = new DictionaryContext())
            {
                return dbContext.Account.SingleOrDefault(p => p.AccountID == accountID);
            }
        }

        public List<Account> GetListAccounts()
        {
            using (var dbContext = new DictionaryContext())
            {
                List<Account> rs = dbContext.Account
                    .Include(p => p.DetailedInformation)
                    .Where(p => p.TypeID != 5).ToList();
                rs.ForEach(item =>
                {
                    dbContext.Entry(item).Collection(p => p.UserPacketInfos).Load();
                    foreach(var userPacketInfo in item.UserPacketInfos)
                    {
                        dbContext.Entry(userPacketInfo).Reference(pp => pp.UserPacket).Load();
                    }
                });
                rs.Reverse();
                return rs;
            }
        }

        public bool DeleteAccount(int accountID)
        {
            using (var dbContext = new DictionaryContext())
            {
                try
                {
                    DetailedInformation detailedInformation = dbContext.DetailedInformation.Find(accountID);
                    dbContext.DetailedInformation.Remove(detailedInformation);
                    dbContext.SaveChanges();

                    Account account = dbContext.Account.Find(accountID);
                    dbContext.Account.Remove(account);
                    dbContext.SaveChanges();

                    string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json";
                    string json = File.ReadAllText(fileFullPath);

                    List<UserSetting> jsonObject = JsonConvert.DeserializeObject<List<UserSetting>>(json);
                    jsonObject.RemoveAll(item => item.UserId == account.AccountID);

                    string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                    File.WriteAllText(fileFullPath, output);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public DetailedInformation GetAccountDetail(int accountID)
        {
            using (var dbContext = new DictionaryContext())
            {
                return dbContext.DetailedInformation.SingleOrDefault(p => p.AccountID == accountID);
            }
        }

        public void UpdateDetailInformation(int userID, DetailedInformation detail)
        {
            using (var db = new DictionaryContext())
            {
                var temp = db.DetailedInformation
                    .Where(p => p.AccountID == userID)
                    .FirstOrDefault();

                temp.Balance = detail.Balance;
                temp.NumberOfConsecutiveDay = detail.NumberOfConsecutiveDay;
                temp.AchievedGoal = detail.AchievedGoal;

                db.SaveChanges();
            }
        }

        public InformationPerDay GetLearningStat_ByID(int accountID, int dayID)
        {
            using (var dbContext = new DictionaryContext())
            {
                return dbContext.InformationPerDay
                    .SingleOrDefault(p => p.AccountID == accountID && p.DayID == dayID);
            }
        }

        /// <summary>
        /// This function creates a new entry in the database (informationperday) for a user's learning statistics for the current
        /// day.
        /// </summary>
        /// <param name="userID">The ID of the user for whom the learning statistics are being created.</param>
        /// <param name="learnedTime">The amount of time (in hours) that the user has spent learning.</param>
        /// <param name="learnedWord">The number of words learned by the user.</param>
        public void CreateLearningStat(int userID, float learnedTime, int learnedWord)
        {
            using (var db = new DictionaryContext())
            {
                var today = Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd"));

                var infor = new InformationPerDay()
                {
                    AccountID = userID,
                    NumberOfLearnedWord = learnedWord,
                    OnlineHour = learnedTime,
                    DayID = today
                };
                db.InformationPerDay.Add(infor);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// lưu thời gian học và số từ học trong 1 ngày
        /// </summary>
        /// <param name="learnedWord"></param>
        /// <param name="learnedTime"></param>
        public void UpdateLearningStat(int userID, InformationPerDay ipd)
        {
            using (var db = new DictionaryContext())
            {
                var today = Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd"));

                var rs = db.InformationPerDay.SingleOrDefault(p => p.AccountID == userID && p.DayID == today);

                if(rs != null)
                {
                    rs.NumberOfLearnedWord = ipd.NumberOfLearnedWord;
                    rs.OnlineHour = ipd.OnlineHour;
                    db.SaveChanges();
                }
            }
        }

        public List<InformationPerDay> GetLearningStat_All_ByUID(int userID)
        {
            using (DictionaryContext db = new DictionaryContext())
            {
                List<InformationPerDay> result = new List<InformationPerDay>();

                var rs = db.InformationPerDay
                                    .Where(p => p.AccountID == userID)
                                    .OrderBy(p => p.DayID)
                                    .ToList();

                int lastDateID = -1;
                foreach (var i in rs)
                {
                    if (lastDateID != -1)
                    {
                        DateTime currentDate = DateTime.ParseExact(i.DayID.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
                        int offset = (int)(currentDate - DateTime.ParseExact(lastDateID.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture)).TotalDays;

                        for (int k = 1; k < offset; ++k)
                        {
                            result.Add(new InformationPerDay()
                            {
                                AccountID = userID,
                                DayID = Convert.ToInt32(currentDate.AddDays(k).ToString("yyyyMMdd")),
                                NumberOfLearnedWord = 0,
                                OnlineHour = 0
                            });
                        }    
                    }
                    result.Add(new InformationPerDay()
                    {
                        AccountID = userID,
                        DayID = i.DayID,
                        NumberOfLearnedWord = i.NumberOfLearnedWord,
                        OnlineHour = i.OnlineHour,
                    });

                    lastDateID = i.DayID;
                }

                return result;
            }
        }


    }
}
