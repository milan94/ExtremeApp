namespace ExtremeIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.membership_card")]
    public partial class membership_card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int membership_card_id { get; set; }

        public int member_id { get; set; }

        public int issuer_user_account_id { get; set; }

        [Required]
        [StringLength(48)]
        public string barcode_number { get; set; }

        public DateTime create_date { get; set; }

        [StringLength(200)]
        public string picture { get; set; }

        public bool active { get; set; }

        public virtual member member { get; set; }

        public virtual user_account user_account { get; set; }
    }
}
