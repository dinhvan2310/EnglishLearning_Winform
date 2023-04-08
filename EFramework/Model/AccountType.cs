using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework.Model
{
    public class AccountType
    {
        public AccountType()
        {
            Accounts = new List<Account>();
        }

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
