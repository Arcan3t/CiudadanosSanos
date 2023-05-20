using Ciudadanos_Sanos.Model;
using Microsoft.EntityFrameworkCore;

namespace Ciudadanos_Sanos.Data
{
    public class CSContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CiudadanosSanos;Trusted_Connection=True;");
        }
    }
}
