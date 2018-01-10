namespace ExtremeIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.attendance")]
    public partial class attendance
    {
        [Key]
        public int attendance_id { get; set; }

        public int member_id { get; set; }

        public DateTime check_in_time { get; set; }

        public bool? is_stuff { get; set; }

        public virtual member member { get; set; }
    }
}
