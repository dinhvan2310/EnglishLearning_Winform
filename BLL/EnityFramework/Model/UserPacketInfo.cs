using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityFrameWork.Model
{
    [Table("UserPacketInfo")]
    public class UserPacketInfo
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey(nameof(UserPacket))]
        public int PacketID { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey(nameof(Account))]
        public int AccountID { get; set; }
        public DateTime DueDate { get; set;}

        public virtual UserPacket UserPacket { set; get; }
        public virtual Account Account { set; get; }
    }
}
