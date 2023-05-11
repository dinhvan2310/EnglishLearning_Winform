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
    [Table("branch")]
    public class Branch
    {
        [Key]
        [Column("synset_id", Order = 0)]
        public decimal SynsetID { get; set; }

        [Column("branch_name")]
        public string BranchName{ get; set; }

        [Key]
        [Column("topic_id", Order = 1)]
        public int TopicID { get; set; }



        [ForeignKey("SynsetID")]
        public virtual wn_synset Wn_synset { get; set; }

        [ForeignKey("TopicID")]
        public virtual Topic Topic  { get; set; }
    }
}
