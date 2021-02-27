using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.Repositories.Interfaces;
using AdamBednorzZadanieDomowe4.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace AdamBednorzZadanieDomowe4.Repositories
{
    /// <summary>
    /// klasa do obslugi tabeli lekarze z bazy danych
    /// </summary>
    public class DoctorsRepository : Repository, IDoctorsRepository
    {
        /// <summary>
        /// metoda zwracajaca wszystkie rekordy z tabeli lekarzy
        /// </summary>
        /// <returns></returns>
        public List<Doctor> GetDoctors()
        {
            return DbContext.Doctors.ToList();
        }
        /// <summary>
        /// metoda pozwalajaca pobrac wszystkich lekarzy
        /// </summary>
        /// <returns></returns>
        public List<DoctorViewModel> GetDoctorViewModels()
        {
            List<Doctor> doctors = DbContext.Doctors.ToList();
            return Mapper.Map<List<Doctor>, List<DoctorViewModel>>(doctors);
        }
    }
}
