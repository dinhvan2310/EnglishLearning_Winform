namespace EFramework.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wn_see_also")]
    public partial class wn_see_also
    {
        [Key]
        [Column(Order = 0)]
        public decimal synset_id_1 { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal wnum_1 { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal synset_id_2 { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal wnum_2 { get; set; }

        public virtual wn_synset wn_synset { get; set; }

        public virtual wn_synset wn_synset1 { get; set; }
    }
}
