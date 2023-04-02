namespace BLL.EntityFrameWork.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wn_word")]
    public partial class wn_word
    {
        [Key]
        [Column(Order = 0)]
        public decimal synset_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal w_num { get; set; }

        [StringLength(50)]
        public string word { get; set; }

        public virtual wn_synset wn_synset { get; set; }
    }
}
