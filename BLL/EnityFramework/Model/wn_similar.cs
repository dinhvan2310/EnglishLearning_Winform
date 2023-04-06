namespace BLL.EntityFrameWork.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wn_similar")]
    public partial class wn_similar
    {
        [Key]
        [Column(Order = 0)]
        public decimal synset_id_1 { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal synset_id_2 { get; set; }

        public virtual wn_synset wn_synset { get; set; }

        public virtual wn_synset wn_synset1 { get; set; }
    }
}
