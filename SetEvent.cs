namespace HMPE1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SetEvent")]
    public partial class SetEvent : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private int _Id;
        private string _EventID;
        private DateTime? _EventDate;
        private string _EventName;


        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));

            }
        }

        [StringLength(50)]
        public string EventID
        {
            get
            {
                return _EventID;
            }
            set
            {
                _EventID = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EventID"));

            }
        }

        [Column(TypeName = "datetime2")]
        public DateTime? EventDate
        {
            get
            {
                return _EventDate;
            }
            set
            {
                _EventDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EventDate"));

            }
        }

        [StringLength(50)]
        public string EventName
        {
            get
            {
                return _EventName;
            }
            set
            {
                _EventName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EventName"));

            }
        }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDate { get; set; }
    }
}
