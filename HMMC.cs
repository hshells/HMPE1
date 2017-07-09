namespace HMPE1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HMMC : DbContext
    {
        public HMMC()
            : base("name=HMMC")
        {
        }

        public virtual DbSet<BMI> BMIs { get; set; }
        public virtual DbSet<BP> BPs { get; set; }
        public virtual DbSet<Eye> Eyes { get; set; }
        public virtual DbSet<HealthEd> HealthEds { get; set; }
        public virtual DbSet<Lab> Labs { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<SetEvent> SetEvents { get; set; }
        public virtual DbSet<Spirometry> Spirometries { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BMI>()
                .Property(e => e.Weight)
                .HasPrecision(4, 1);

            modelBuilder.Entity<BMI>()
                .Property(e => e.HeightInOnly)
                .HasPrecision(3, 1);

            modelBuilder.Entity<BMI>()
                .Property(e => e.HeightFT)
                .HasPrecision(1, 0);

            modelBuilder.Entity<BMI>()
                .Property(e => e.HeightIn)
                .HasPrecision(3, 1);

            modelBuilder.Entity<BMI>()
                .Property(e => e.Waist)
                .HasPrecision(3, 1);

            modelBuilder.Entity<BMI>()
                .Property(e => e.BMIResult)
                .HasPrecision(3, 1);

            modelBuilder.Entity<BMI>()
                .Property(e => e.PEDBMI)
                .HasPrecision(4, 1);

            modelBuilder.Entity<BMI>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BMI>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BP>()
                .Property(e => e.BPSystolic)
                .HasPrecision(4, 1);

            modelBuilder.Entity<BP>()
                .Property(e => e.BPDiastolic)
                .HasPrecision(4, 1);

            modelBuilder.Entity<BP>()
                .Property(e => e.ArmID)
                .IsUnicode(false);

            modelBuilder.Entity<BP>()
                .Property(e => e.BPSystolic2)
                .HasPrecision(4, 1);

            modelBuilder.Entity<BP>()
                .Property(e => e.BPDiastolic2)
                .HasPrecision(4, 1);

            modelBuilder.Entity<BP>()
                .Property(e => e.ArmID2)
                .IsUnicode(false);

            modelBuilder.Entity<BP>()
                .Property(e => e.BPComments)
                .IsUnicode(false);

            modelBuilder.Entity<BP>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BP>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Eye>()
                .Property(e => e.OD20)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Eye>()
                .Property(e => e.ODPH20)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Eye>()
                .Property(e => e.OS20)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Eye>()
                .Property(e => e.OSPH20)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Eye>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Eye>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<HealthEd>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<HealthEd>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Lab>()
                .Property(e => e.TC)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Lab>()
                .Property(e => e.HDL)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Lab>()
                .Property(e => e.TCRatio)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Lab>()
                .Property(e => e.LDL)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Lab>()
                .Property(e => e.Trig)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Lab>()
                .Property(e => e.Glu)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Lab>()
                .Property(e => e.HBA1C)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Lab>()
                .Property(e => e.Alb)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Lab>()
                .Property(e => e.Cre)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Lab>()
                .Property(e => e.AlbCre)
                .IsUnicode(false);

            modelBuilder.Entity<Lab>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Lab>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.KitNum)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.EventID)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.MembNo)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Physician)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.AptSuiteFloor)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SetEvent>()
                .Property(e => e.EventID)
                .IsUnicode(false);

            modelBuilder.Entity<SetEvent>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<SetEvent>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SetEvent>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Spirometry>()
                .Property(e => e.SpirometryFVC)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Spirometry>()
                .Property(e => e.SpirometryFEV1)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Spirometry>()
                .Property(e => e.SpirometryRatio)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Spirometry>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Spirometry>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Survey>()
                .Property(e => e.DiabetesType)
                .IsUnicode(false);

            modelBuilder.Entity<Survey>()
                .Property(e => e.DiabetesHowLong)
                .IsUnicode(false);

            modelBuilder.Entity<Survey>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Survey>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CreatedDate)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UpdatedDate)
                .IsUnicode(false);
        }
    }
}
