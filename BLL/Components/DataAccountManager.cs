using System;
using System.Windows.Forms;
using BLL.EntityFrameWork;
using BLL.EntityFrameWork.Model;

namespace BLL.Components
{
    public class DataAccountManager
    {
        
        public bool SaveAccount(string name, bool gender, DateTime? ngaySinh, string userName, string password, string email)
        {
            try
            {
                using (var dbContext = new DictionaryContext())
                {
                    Account account = new Account()
                    {
                        UserName = userName,
                        Password = password,
                        Name = name,
                        BirthDate = ngaySinh,
                        Email = email,
                        Gender = gender,
                        TypeID = 4,
                        ProfilePicture = "",
                    };
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
