using System;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using EFramework;
using EFramework.Model;

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
                Account old = dbContext.account.Single(p => p.AccountID == account.AccountID);

                old.Name = account.Name;
                old.Email = account.Email;
                old.BirthDate = account.BirthDate;
                old.Gender = account.Gender;

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
