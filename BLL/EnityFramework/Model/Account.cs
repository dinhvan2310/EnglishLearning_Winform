using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityFrameWork.Model
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string ProfilePicture { get; set; }

        [ForeignKey(nameof(AccountType))]
        public int TypeID { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual DetailedInformation DetailedInformation { get; set;}
        public virtual ICollection<InformationPerDay> InformationPerDays { get; set; }
        public virtual ICollection<UserPacketInfo> UserPacketInfos { get; set;} 
        public virtual ICollection<Notebook> Notebooks { set; get; }
        public virtual ICollection<HistoryEnglishContainer> HistoryEnglishContainers { get; set; }
        public virtual ICollection<HistoryVietNameseContainer> HistoryVietNameseContainers { get; set;}
    }
}
