namespace HMPE1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lead")]
    public partial class Lead
    {
        public int Id { get; set; }

        public bool? Inactive { get; set; }

        public bool? LeadTest { get; set; }

        [StringLength(50)]
        public string KitNum { get; set; }

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
