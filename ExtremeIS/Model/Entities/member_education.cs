namespace ExtremeIS.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informacioni_db.member_education")]
    public partial class member_education
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int member_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int education_level_id { get; set; }

        public DateTime exam_date { get; set; }

        [StringLength(45)]
        public string commission_member_1 { get; set; }

        [StringLength(45)]
        public string commission_member_2 { get; set; }

        [StringLength(45)]
        public string commission_member_3 { get; set; }

        public virtual education_level education_level { get; set; }

        public virtual member member { get; set; }
    }
}
