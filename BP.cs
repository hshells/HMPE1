namespace HMPE1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Windows.Controls;

    [Table("BP")]
    public partial class BP : IDataErrorInfo
    {
        private decimal bpsystolic;
        private decimal bpdiastolic;

        //public bool DoValidation { get; set; }
        public int Id { get; set; }

        public bool Inactive { get; set; }

        public decimal BPSystolic
        {
            get { return bpsystolic; }
            set { bpsystolic = value; }
        }

        public decimal BPDiastolic
        {
            get { return bpdiastolic; }
            set { bpdiastolic = value; }
        }

        [StringLength(1)]
        public string ArmID { get; set; }

        public decimal BPSystolic2 { get; set; }

        public decimal BPDiastolic2 { get; set; }

        [StringLength(1)]
        public string ArmID2 { get; set; }

        public bool? BPAbnFlag { get; set; }

        public string BPComments { get; set; }

        public bool? Referral { get; set; }

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

        public string Error
        {
            //get { throw new NotImplementedException(); }
            get
            {
                //if (DoValidation)
                //{
                //    if (error on any properties)
                //     return "error on these .....";
                //}
                return null; // no errors
            }
        }

        public string this[string columnName]
        {
            get
            {
                string result = null;

                if (columnName == "BPSystolic")
                {
                    if (bpsystolic <= 1 || bpsystolic >= 300)
                            result = "Please enter a valid BPSystolic.";
                }

                if (columnName == "BPSystolic")
                {
                    if (bpsystolic >= 160)
                        result = "TAKE A SECOND BLOOD PRESSURE.";
                }

                if (columnName == "BPDiastolic")
                {
                    if (bpdiastolic <= 1 || bpdiastolic >= 200)
                        result = "Please enter a valid BPDiastolic.";
                }

                if (columnName == "BPDiastolic")
                {
                    if (bpdiastolic >= 100)
                        result = "TAKE A SECOND BLODD PRESSURE.";
                }

                if (columnName == "BPSystolic2")
                {
                    if (BPSystolic2 >= 300)
                        result = "Please enter a valid BPSystolic2.";
                }

                if (columnName == "BPDiastolic2")
                {
                    if (BPDiastolic2 >= 200)
                        result = "Please enter a valid BPDiastolic2.";
                }

                if (columnName == "ArmID")
                {
                    if (ArmID  == null)
                        result = "Please select an arm.";
                }

                if (columnName == "ArmID2")
                {
                    if (ArmID2 == null)
                        result = "Please select an arm.";
                }

                return result;
            }
        }

    }
}
