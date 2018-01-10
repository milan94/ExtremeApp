namespace ExtremeIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.daily_ticket_type")]
    public partial class daily_ticket_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public daily_ticket_type()
        {
            daily_ticket = new HashSet<daily_ticket>();
        }

        [Key]
        public int daily_ticket_type_id { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        public decimal price { get; set; }

        public DateTime? last_modified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<daily_ticket> daily_ticket { get; set; }
    }
}
