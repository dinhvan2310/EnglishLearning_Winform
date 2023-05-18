using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework.Model
{
    [Table("Account")]
    public class Account
    {
        public Account()
        {
            DetailedInformation = new DetailedInformation();
            InformationPerDays = new HashSet<InformationPerDay>();
            UserPacketInfos = new HashSet<UserPacketInfo>();
            Notebooks = new HashSet<Notebook>();
        }

        [Key]
        [Required]
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }

        public int TypeID { get; set; }

        [ForeignKey("TypeID")]
        public virtual AccountType AccountType { get; set; }

        [ForeignKey("AccountID")]
        public virtual DetailedInformation DetailedInformation { get; set;}
        public virtual ICollection<InformationPerDay> InformationPerDays { get; set; }
        public virtual ICollection<UserPacketInfo> UserPacketInfos { get; set;} 
        public virtual ICollection<Notebook> Notebooks { set; get; }
    }
}
