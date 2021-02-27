using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.Repositories.Interfaces;
using AdamBednorzZadanieDomowe4.ViewModels;
using System.Collections.Generic;
using System.Linq;


namespace AdamBednorzZadanieDomowe4.Repositories
{
    /// <summary>
    /// klasa gdzie sa metody do komunikacji z tabela wizyt z baza danych
    /// </summary>
    public class VisitsRepository : Repository, IVisitsRepository
    {
        /// <summary>
        /// metoda pobierajace wszystkie rekordy z tabeli wizyty
        /// </summary>
        /// <returns></returns>
        public List<Visit> GetVisits()
        {
            return DbContext.Visits.ToList();
        }

        public List<VisitViewModel> GetVisitViewModels()
        {
            List<Visit> visits = DbContext.Visits.ToList();
            return Mapper.Map<List<Visit>, List<VisitViewModel>>(visits);
        }

        /// <summary>
        /// metoda pozwalajaca dodac do bazy danych wizyte
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="typeDoctor"></param>
        /// <returns></returns>
        public bool AddVisit(string firstName, string lastName, string password, string typeDoctor)
        {
            //szukamy pacjenta i lekarza
            Patient patient = DbContext.Patients.SingleOrDefault(p => p.FirstName == firstName && p.LastName == lastName && p.Password == password);
            Doctor doctor = DbContext.Doctors.SingleOrDefault(d => d.Type == typeDoctor);
            //jesli nie ma takiego pacjenta lub lekarza w bazie zwroc falsz
            if (patient == null || doctor == null)
                return false;

            //dodajemy nowa wizyte
            Visit visitToAdd = new Visit()
            {
                PatientId = patient.Id,
                DoctorId = doctor.Id
            };
            
            //dodajemy wizyte
            DbContext.Visits.Add(visitToAdd);

            //zwracamy true jesli wszystko przebieglo pomyslnie
            return DbContext.SaveChanges() > 0;

        }
    }
}
