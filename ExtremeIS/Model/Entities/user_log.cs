namespace ExtremeIS.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.user_log")]
    public partial class user_log
    {
        [Key]
        public int user_log_id { get; set; }

        public int user_account_id { get; set; }

        public DateTime date_time { get; set; }

        [Column("event")]
        [Required]
        [StringLength(20)]
        public string _event { get; set; }

        [Required]
        [StringLength(255)]
        public string description { get; set; }

        public virtual user_account user_account { get; set; }
    }
}
