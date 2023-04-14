using EFramework.Model;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EnityFramework.Model
{
    [Table("topic")]
    public class Topic
    {
        [Key]
        [Column("synset_id", Order = 0)]
        public decimal SynsetID { get; set; }

        [Column("topic_name")]
        public string TopicName{ get; set; }

        public virtual wn_synset Wn_synset { get; set; }
    }
}
