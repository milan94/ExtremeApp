namespace ExtremeIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.member")]
    public partial class member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public member()
        {
            attendances = new HashSet<attendance>();
            gear_borrowing = new HashSet<gear_borrowing>();
            membership_card = new HashSet<membership_card>();
            membeship_fee_payment = new HashSet<membeship_fee_payment>();
            user_account = new HashSet<user_account>();
        }

        [Key]
        public int member_id { get; set; }

        [Required]
        [StringLength(25)]
        public string first_name { get; set; }

        [Required]
        [StringLength(45)]
        public string last_name { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string sex { get; set; }

        public DateTime? birth_date { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(16)]
        public string phone_number { get; set; }

        [StringLength(45)]
        public string email { get; set; }

        public DateTime registration_date { get; set; }

        public DateTime? last_modified { get; set; }

        public bool active { get; set; }

        public int education_level_id { get; set; }

        public int membership_type_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attendance> attendances { get; set; }

        public virtual education_level education_level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gear_borrowing> gear_borrowing { get; set; }

        public virtual membership_type membership_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<membership_card> membership_card { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<membeship_fee_payment> membeship_fee_payment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_account> user_account { get; set; }
    }
}
