namespace ExtremeIS.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.education_level")]
    public partial class education_level
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public education_level()
        {
            member_education = new HashSet<member_education>();
        }

        [Key]
        public int education_level_id { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<member_education> member_education { get; set; }
    }
}
