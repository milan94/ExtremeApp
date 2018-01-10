namespace ExtremeIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.gear_borrowing")]
    public partial class gear_borrowing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gear_borrowing()
        {
            gear_borrowing_items = new HashSet<gear_borrowing_items>();
        }

        [Key]
        public int gear_borrowing_id { get; set; }

        public int member_id { get; set; }

        public int issuer_user_account_id { get; set; }

        public int? receiver_user_account_id { get; set; }

        public DateTime borrowing_date { get; set; }

        public DateTime return_date { get; set; }

        public DateTime? last_modified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gear_borrowing_items> gear_borrowing_items { get; set; }

        public virtual member member { get; set; }

        public virtual user_account user_account { get; set; }

        public virtual user_account user_account1 { get; set; }
    }
}
