namespace EFramework.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wn_word")]
    public partial class wn_word
    {
        public wn_word()
        {
            HistoryContainer = new List<HistoryEnglishContainer>();
            Notebooks = new List<Notebook>();
        }

        [Key]
        [Column(Order = 0)]
        public decimal synset_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal w_num { get; set; }

        [StringLength(50)]
        public string word { get; set; }

        public virtual wn_synset Wn_synset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryEnglishContainer> HistoryContainer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notebook> Notebooks { get; set; }
    }
}
