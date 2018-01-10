namespace ExtremeIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.daily_ticket")]
    public partial class daily_ticket
    {
        [Key]
        public int daily_ticket_id { get; set; }

        public int issuer_user_account_id { get; set; }

        public int daily_ticket_type_id { get; set; }

        public decimal price { get; set; }

        public DateTime create_date { get; set; }

        public virtual daily_ticket_type daily_ticket_type { get; set; }

        public virtual user_account user_account { get; set; }
    }
}
