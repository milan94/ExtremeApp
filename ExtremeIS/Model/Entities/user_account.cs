namespace ExtremeIS.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.user_account")]
    public partial class user_account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_account()
        {
            daily_ticket = new HashSet<daily_ticket>();
            gear_borrowing = new HashSet<gear_borrowing>();
            gear_borrowing1 = new HashSet<gear_borrowing>();
            gear_write_off = new HashSet<gear_write_off>();
            membership_card = new HashSet<membership_card>();
            membeship_fee_payment = new HashSet<membeship_fee_payment>();
            user_log = new HashSet<user_log>();
        }

        [Key]
        public int user_account_id { get; set; }

        public int member_id { get; set; }

        [Required]
        [StringLength(45)]
        public string username { get; set; }

        [Required]
        [StringLength(64)]
        public string password { get; set; }

        [Required]
        [StringLength(45)]
        public string privilegies { get; set; }

        public DateTime create_date { get; set; }

        public DateTime? last_modified { get; set; }

        public bool? active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<daily_ticket> daily_ticket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gear_borrowing> gear_borrowing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gear_borrowing> gear_borrowing1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gear_write_off> gear_write_off { get; set; }

        public virtual member member { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<membership_card> membership_card { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<membeship_fee_payment> membeship_fee_payment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_log> user_log { get; set; }
    }
}
