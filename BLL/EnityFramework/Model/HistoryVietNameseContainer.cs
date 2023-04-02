using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityFrameWork.Model
{
    [Table("HistoryVietNameseContainer")]
    public class HistoryVietNameseContainer
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey(nameof(Account))]
        public int AccountID { get; set;}
        [Key]
        [Column(Order = 1)]
        [ForeignKey(nameof(Word_Viet))]
        public int WordID { get; set; }

        public virtual word_viet Word_Viet { set; get; }
        public virtual Account Account { get; set;}

    }
}
