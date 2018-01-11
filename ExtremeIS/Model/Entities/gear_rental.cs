namespace ExtremeIS.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.gear_rental")]
    public partial class gear_rental
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gear_rental()
        {
            gear_rental_items = new HashSet<gear_rental_items>();
        }

        [Key]
        public int Gear_rental_id { get; set; }

        public int issuer_user_account_id { get; set; }

        public int? receiver_user_account_id { get; set; }

        [Required]
        [StringLength(25)]
        public string renter_first_name { get; set; }

        [Required]
        [StringLength(45)]
        public string renter_last_name { get; set; }

        [Required]
        [StringLength(20)]
        public string renter_id_number { get; set; }

        [StringLength(16)]
        public string renter_phone_number { get; set; }

        public DateTime rental_date { get; set; }

        public DateTime return_date { get; set; }

        public bool is_returned { get; set; }

        public decimal price { get; set; }

        [StringLength(255)]
        public string remark { get; set; }

        public DateTime? last_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gear_rental_items> gear_rental_items { get; set; }

        public virtual user_account user_account { get; set; }

        public virtual user_account user_account1 { get; set; }
    }
}
