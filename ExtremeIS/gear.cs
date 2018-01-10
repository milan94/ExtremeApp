namespace ExtremeIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.gear")]
    public partial class gear
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gear()
        {
            gear_size_items = new HashSet<gear_size_items>();
        }

        [Key]
        public int gear_id { get; set; }

        public int gear_category_id { get; set; }

        public int manufacturer_id { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string descritption { get; set; }

        public virtual gear_category gear_category { get; set; }

        public virtual manufacturer manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gear_size_items> gear_size_items { get; set; }
    }
}
