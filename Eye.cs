namespace HMPE1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Eye")]
    public partial class Eye
    {
        public int Id { get; set; }

        public bool? Inactive { get; set; }

        public bool? EyeScreening { get; set; }

        public decimal? OD20 { get; set; }

        public decimal? ODPH20 { get; set; }

        public decimal? OS20 { get; set; }

        public decimal? OSPH20 { get; set; }

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
