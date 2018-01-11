namespace ExtremeIS.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.membeship_fee_payment")]
    public partial class membeship_fee_payment
    {
        [Key]
        public int membeship_fee_payment_id { get; set; }

        public int member_id { get; set; }

        public int issuer_user_account_id { get; set; }

        public sbyte month { get; set; }

        [Column(TypeName = "year")]
        public short year { get; set; }

        public decimal price { get; set; }

        public bool is_paid { get; set; }

        public bool? is_free_of_charge { get; set; }

        public DateTime payment_date { get; set; }

        public DateTime? last_updated { get; set; }

        public virtual member member { get; set; }

        public virtual user_account user_account { get; set; }
    }
}
