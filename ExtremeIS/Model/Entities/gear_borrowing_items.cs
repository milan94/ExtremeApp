namespace ExtremeIS.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.gear_borrowing_items")]
    public partial class gear_borrowing_items
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gear_borrowing_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gear_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gear_size_id { get; set; }

        [Required]
        [StringLength(45)]
        public string quantity { get; set; }

        public virtual gear_borrowing gear_borrowing { get; set; }

        public virtual gear_size_items gear_size_items { get; set; }
    }
}
