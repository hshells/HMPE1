namespace HMPE1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Participant")]
    public partial class Participant
    {
        public int Id { get; set; }

        public bool? Inactive { get; set; }

        [StringLength(50)]
        public string EventID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EventDate { get; set; }

        [StringLength(100)]
        public string EventName { get; set; }

        [StringLength(50)]
        public string MembNo { get; set; }

        [StringLength(50)]
        public string Physician { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string AptSuiteFloor { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DOB { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        public bool? NonMemb { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Column(TypeName = "image")]
        public byte[] Signature { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDate { get; set; }

        public List<BMI> BMI { get; set; }

        public List<BP> BP { get; set; }

        public List<Eye> Eye { get; set; }

        public List<HealthEd> HealthEd { get; set; }

        public List<Lab> Lab { get; set; }

        public List<Lead> Lead { get; set; }

        public List<Spirometry> Spirometry { get; set; }

        public List<Survey> Survey { get; set; }
    }
}
