namespace HMPE1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BMI")]
    public partial class BMI
    {
        public int Id { get; set; }

        public bool? Inactive { get; set; }

        public decimal? Weight { get; set; }

        public decimal? HeightInOnly { get; set; }

        public decimal? HeightFT { get; set; }

        public decimal? HeightIn { get; set; }

        public decimal? Waist { get; set; }

        public decimal? BMIResult { get; set; }

        public decimal? PEDBMI { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDate { get; set; }

        public int? ParticipantId { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
