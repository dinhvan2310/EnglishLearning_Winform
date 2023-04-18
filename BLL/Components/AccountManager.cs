using System;
using System.Collections.Generic;
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

        public List<Account> GetListAccounts()
        {
            using (var dbContext = new DictionaryContext())
            {
                return dbContext.Account.Where(p => p.TypeID != 5).Include(p => p.DetailedInformation).ToList();
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
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public DetailedInformation GetAccountDetail(int accountID)
        {
            using (var dbContext = new DictionaryContext())
            {
                return dbContext.DetailedInformation.Single(p => p.AccountID == accountID);
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

        public void UpdateDetailInformation(int userID, DIAdjustment adjustment)
        {
            using (var db = new DictionaryContext())
            {
                var temp = db.DetailedInformation
                    .Where(p => p.AccountID == userID)
                    .FirstOrDefault();

                switch (adjustment.ConsecutiveValue)
                {
                    case -1:
                        temp.NumberOfConsecutiveDay = 1;
                        break;
                    case 1:
                        temp.NumberOfConsecutiveDay += 1;
                        break;
                }
                temp.Balance += adjustment.BalanceOffset;

                db.SaveChanges();
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
