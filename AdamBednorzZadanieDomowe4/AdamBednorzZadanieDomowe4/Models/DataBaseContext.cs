using AdamBednorzZadanieDomowe4.Models.Entities;
using System.Data.Entity;

namespace AdamBednorzZadanieDomowe4.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext():base("ConnectionString")
        {
        }
        //Tabele bazy danych
        public DbSet<Doctor> Doctors { get; set; }
        public  DbSet<Patient> Patients { get; set; }
        public  DbSet<Visit> Visits { get; set; }
        public  DbSet<Medicine> Medicines { get; set; }
        public  DbSet<Purchase> Purchases { get; set; }
        public  DbSet<Dish> Dishes { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public DbSet<InformationHospital> InformationHospitals { get; set; }
    }
}
