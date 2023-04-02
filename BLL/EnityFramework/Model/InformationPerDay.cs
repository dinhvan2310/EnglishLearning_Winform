using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityFrameWork.Model
{
    [Table("InformationPerDay")]
    public class InformationPerDay
    {
        [Key]
        [Column(Order = 0)]
        public int DayID { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey(nameof(Account))]
        public int AccountID { get; set; }
        public int NumberOfLearnedWord { set; get; }
        public int OnlineHour { set; get; }

        public virtual Account Account { get; set; }
    }
}
