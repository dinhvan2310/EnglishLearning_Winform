using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityFrameWork.Model
{
    [Table("UserPacket")]
    public class UserPacket
    {
        public UserPacket()
        {
            UserPacketInfos = new List<UserPacketInfo>();
        }

        [Key]
        public int PacketID { get; set; }
        public string Name { get; set; }
        public int Price { get; set;}
        public int TimeOfUse { get; set;}

        public virtual ICollection<UserPacketInfo> UserPacketInfos { set; get; }
    }
}
