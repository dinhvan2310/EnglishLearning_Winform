using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework.Model
{
    [Table("DetailedInformation")]
    public class DetailedInformation
    {
        [Key]
        [ForeignKey(nameof(Account))]
        public int AccountID { get; set;}
        public int Balance { get; set;}
        public int NumberOfLoginDay { set; get; }
        public int NumberOfConsecutiveDay { set; get; }

        public virtual Account Account { set; get; }
    }
}
