using System;
using System.Data.Entity;
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

                    dbContext.account.Add(account);
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
                Account old = dbContext.account.SingleOrDefault(p => p.AccountID == account.AccountID);

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
                return dbContext.account.Single(p => p.AccountID == accountID);
            }
        }

        public DetailedInformation GetAccountDetail(int accountID)
        {
            using (var dbContext = new DictionaryContext())
            {
                return dbContext.detailedInformation.Single(p => p.AccountID == accountID);
            }
        }

        /// <summary>
        /// lưu thời gian học và số từ học trong 1 ngày
        /// </summary>
        /// <param name="wordNumber"></param>
        /// <param name="learnedTime"></param>
        public void UpdateLearningStat(InformationPerDay stat)
        {
            using (var db = new DictionaryContext())
            {
                var today = Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd"));

                var rs = db.informationPerDay.SingleOrDefault(p => p.AccountID == stat.AccountID && p.DayID == today);

                if (rs == null)
                {
                    var infor = new InformationPerDay()
                    {
                        AccountID = stat.AccountID,
                        NumberOfLearnedWord = 0,
                        OnlineHour = 0,
                        DayID = today
                    };
                    db.informationPerDay.Add(infor);
                    db.SaveChanges();
                }
                else
                {

                    rs.NumberOfLearnedWord += stat.NumberOfLearnedWord;
                    rs.OnlineHour += stat.OnlineHour;
                    db.SaveChanges();
                }
            }
        }

        public LearningStats GetLearningStats_ByUID(int userID)
        {
            using (DictionaryContext db = new DictionaryContext())
            {
                LearningStats result = new LearningStats();

                var rs = db.informationPerDay.Where(p => p.AccountID == userID).
                                              OrderBy(p => p.DayID).
                                              Select(p => new { p.NumberOfLearnedWord, p.OnlineHour });
                foreach (var i in rs)
                {
                    result.WordStats.Add(i.NumberOfLearnedWord);
                    result.TimeStats.Add((int)i.OnlineHour);
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
