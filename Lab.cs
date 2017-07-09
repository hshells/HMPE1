namespace HMPE1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lab")]
    public partial class Lab
    {
        public int Id { get; set; }

        public bool? Inactive { get; set; }

        public decimal? TC { get; set; }

        public decimal? HDL { get; set; }

        public decimal? TCRatio { get; set; }

        public decimal? LDL { get; set; }

        public decimal? Trig { get; set; }

        public decimal? Glu { get; set; }

        public decimal? HBA1C { get; set; }

        public decimal? Alb { get; set; }

        public decimal? Cre { get; set; }

        [StringLength(4)]
        public string AlbCre { get; set; }

        public bool? hCG { get; set; }

        public bool? Ketones { get; set; }

        public bool? Chlamydia { get; set; }

        public bool? Pregnancy { get; set; }

        public bool? HIV { get; set; }

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
