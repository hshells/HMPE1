namespace HMPE1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Survey")]
    public partial class Survey
    {
        public int Id { get; set; }

        public bool? Inactive { get; set; }

        public bool? Smoke { get; set; }

        public bool? Pregnant { get; set; }

        public bool? HighCholesterol { get; set; }

        public bool? HighBP { get; set; }

        public bool? Diabetes { get; set; }

        [StringLength(6)]
        public string DiabetesType { get; set; }

        [StringLength(50)]
        public string DiabetesHowLong { get; set; }

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
