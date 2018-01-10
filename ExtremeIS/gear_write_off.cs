namespace ExtremeIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.gear_write_off")]
    public partial class gear_write_off
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gear_write_off_id { get; set; }

        public int gear_id { get; set; }

        public int gear_size_id { get; set; }

        public int user_account_id { get; set; }

        public int quantity { get; set; }

        public DateTime date_time { get; set; }

        public virtual gear_size_items gear_size_items { get; set; }

        public virtual user_account user_account { get; set; }
    }
}
