using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain.Model;

namespace PrimaryHealthcareCentre.Domain.EF
{
    public class PrimaryHealthCentreDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<MedicalCard> MedicalCards { get; set; } = null!;
        public DbSet<Preparation> Preparations { get; set; } = null!;
        public DbSet<Prescription> Prescriptions { get; set; } = null!;
        public DbSet<Reception> LogOfReception { get; set; } = null!;
        public DbSet<Examination> Examinations { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB;database=PrimaryHealthCareCentreDb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;");
        }
    }
}
