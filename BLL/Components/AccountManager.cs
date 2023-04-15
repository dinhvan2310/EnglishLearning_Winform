using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using BLL.TransferObjects;
using BLL.Workflows;
using EFramework;
using EFramework.Model;
using MySqlX.XDevAPI.Common;

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

        public DetailedInformation GetAccountDetail(int accountID)
        {
            using (var dbContext = new DictionaryContext())
            {
                return dbContext.DetailedInformation.Single(p => p.AccountID == accountID);
            }
        }

        /// <summary>
        /// lưu thời gian học và số từ học trong 1 ngày
        /// </summary>
        /// <param name="learnedWord"></param>
        /// <param name="learnedTime"></param>
        public void UpdateLearningStat(int userID, float learnedTime, int learnedWord)
        {
            using (var db = new DictionaryContext())
            {
                var today = Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd"));

                var rs = db.InformationPerDay.SingleOrDefault(p => p.AccountID == userID && p.DayID == today);

                if (rs == null)
                {
                    var infor = new InformationPerDay()
                    {
                        AccountID = userID,
                        NumberOfLearnedWord = 0,
                        OnlineHour = 0,
                        DayID = today
                    };
                    db.InformationPerDay.Add(infor);
                    db.SaveChanges();
                }
                else
                {

                    rs.NumberOfLearnedWord += learnedWord;
                    rs.OnlineHour += learnedTime;
                    db.SaveChanges();
                }
            }
        }

        public LearningStats GetLearningStats_ByUID(int userID)
        {
            using (DictionaryContext db = new DictionaryContext())
            {
                LearningStats result = new LearningStats();

                var rs = db.InformationPerDay
                                    .Where(p => p.AccountID == userID)
                                    .OrderBy(p => p.DayID)
                                    .ToList();

                int lastDate = -1;
                foreach (var i in rs)
                {
                    if (lastDate != -1)
                    {
                        int offset = (int)(DateTime.ParseExact(i.DayID.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture)
                            - DateTime.ParseExact(lastDate.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture)).TotalDays;

                        for (int k = 0; k < offset; ++k)
                        {
                            result.Stats.Add(new Stat());
                        }    
                    }
                    result.Stats.Add(new Stat()
                    {
                        TimeAmount = (int)i.OnlineHour,
                        WordCount = i.NumberOfLearnedWord
                    });

                    lastDate = i.DayID;
                }

                return result;
            }
        }

        public int GetNumberOfLearnedDay(int accountID)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                return dbContext.InformationPerDay.Where(p => p.AccountID == accountID).Count();
            }
        }

        public int GetNumberOfLearnedWord(int accountID)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                int result = 0;

                var temp = dbContext.InformationPerDay
                    .Where(p => p.AccountID == accountID)
                    .Select(p => p.NumberOfLearnedWord)
                    .ToList();

                temp.ForEach(item =>
                {
                    result += item;
                });

                return result;
            }
        }

        public float GetNumberOfLearnedHour(int accountID)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                float result = 0;

                var temp = dbContext.InformationPerDay
                    .Where(p => p.AccountID == accountID)
                    .Select(p => p.OnlineHour)
                    .ToList();

                temp.ForEach(item =>
                {
                    result += item;
                });

                return result;
            }
        }

        public float GetNumberOfLearnedHour_Today(int accountID)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                float result = 0;

                int dayID = Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd"));
                var temp = dbContext.InformationPerDay
                    .Where(p => p.AccountID == accountID
                    && p.DayID == dayID)
                    .Select(p => p.OnlineHour)
                    .ToList();

                temp.ForEach(item =>
                {
                    result += item;
                });

                return result;
            }
        }

        /*public bool checkExsit(Account account)
        {
            using (var dbContext = new Model1())
            {
                if (dbContext.account.Find(account.AccountID) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }*/

    }
}
