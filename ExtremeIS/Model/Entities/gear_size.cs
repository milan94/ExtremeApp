namespace ExtremeIS.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.gear_size")]
    public partial class gear_size
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gear_size()
        {
            gear_size_items = new HashSet<gear_size_items>();
        }

        [Key]
        public int gear_size_id { get; set; }

        [Required]
        [StringLength(10)]
        public string value { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gear_size_items> gear_size_items { get; set; }
    }
}
