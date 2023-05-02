namespace EFramework.Model
{
    using BLL.EnityFramework.Model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wn_synset")]
    public partial class wn_synset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wn_synset()
        {
            Wn_antonym = new HashSet<wn_antonym>();
            Wn_antonym1 = new HashSet<wn_antonym>();
            Wn_similar = new HashSet<wn_similar>();
            Wn_similar1 = new HashSet<wn_similar>();
            Wn_hypernym = new HashSet<wn_hypernym>();
            Wn_hypernym1 = new HashSet<wn_hypernym>();
            Wn_derived = new HashSet<wn_derived>();
            Wn_derived1 = new HashSet<wn_derived>();
            Wn_see_also = new HashSet<wn_see_also>();
            Wn_see_also1 = new HashSet<wn_see_also>();
            Wn_verb_frame = new HashSet<wn_verb_frame>();
            Wn_word = new HashSet<wn_word>();
            topic = new HashSet<Branch>();
        }

        [Key]
        public decimal synset_id { get; set; }

        [StringLength(255)]
        public string definition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_antonym> Wn_antonym { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_antonym> Wn_antonym1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_similar> Wn_similar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_similar> Wn_similar1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_hypernym> Wn_hypernym { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_hypernym> Wn_hypernym1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_derived> Wn_derived { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_derived> Wn_derived1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_see_also> Wn_see_also { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_see_also> Wn_see_also1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_verb_frame> Wn_verb_frame { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wn_word> Wn_word { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Branch> topic { get; set; }
    }
}
