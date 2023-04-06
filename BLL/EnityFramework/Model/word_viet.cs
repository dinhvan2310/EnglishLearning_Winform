namespace BLL.EntityFrameWork.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("word_viet")]
    public partial class word_viet
    {
        public word_viet()
        {
            HistoryContainer = new List<HistoryVietNameseContainer>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idx { get; set; }

        [StringLength(255)]
        public string word { get; set; }

        [StringLength(1073741823)]
        public string detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryVietNameseContainer> HistoryContainer { get; set; }
    }
}
