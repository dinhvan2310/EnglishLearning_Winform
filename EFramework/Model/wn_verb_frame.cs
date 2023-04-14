namespace EFramework.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wn_verb_frame")]
    public partial class wn_verb_frame
    {
        [Key]
        [Column(Order = 0)]
        public decimal synset_id_1 { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal f_num { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal w_num { get; set; }

        public virtual wn_synset Wn_synset { get; set; }
    }
}
