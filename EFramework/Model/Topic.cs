using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.EnityFramework.Model;

namespace EFramework.Model
{
    [Table("topic")]
    public class Topic
    {
        public Topic()
        {
            Branches = new HashSet<Branch>();
        }

        [Key]
        [Column("topic_id", Order = 0)]
        public int TopicID { get; set; }

        [Column("topic_name")]
        public string TopicName { get; set; }

        [Column("background")]
        public byte[] Background { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }
    }
}
