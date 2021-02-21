using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe4.Repositories
{
    /// <summary>
    /// klasa do oblusgi tabeli pacjentów z bazy danych
    /// </summary>
    public class PatientsRepository : Repository, IPatientsRepository
    {
        /// <summary>
        /// metoda pozwalajaca sie zalogowac do systemu
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool SignIn(string firstName, string lastName, string password)
        {
            Patient patient = DbContext.Patients.SingleOrDefault(p => p.FirstName == firstName && p.LastName == lastName && p.Password == password);
            return patient != null;
        }
        /// <summary>
        /// metoda pozwalajaca dodac nowego pacjenta do bazy danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Register(string firstName, string lastName, string password)
        {
            //tworzymy pacjenta w bazie
            Patient patientToAdd = new Patient()
            {
                FirstName = firstName,
                LastName = lastName,
                Password = password
            };

            //sprawdzamy czy istnieje taki użytkownik w bazie
            Patient foundedPatient = DbContext.Patients.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName && p.Password == password);
            if (foundedPatient != null)
                return false;

            //dodajemy pacjenta do bazy danych
            DbContext.Patients.Add(patientToAdd);

            //zapisujemy i zwracamy czy zapytanie przebiegło pomyslnie
            return DbContext.SaveChanges() > 0;
        }
        public bool DeletePatient(string firstName, string lastName, string password)
        {
            //sprawdzamy czy istnieje taki użytkownik w bazie, ktorego chcemy usunac
            Patient patientToDelete = DbContext.Patients.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName && p.Password == password);
            if (patientToDelete == null)
                return false;
            //usuwamy pacjenta z bazy danych
            DbContext.Patients.Remove(patientToDelete);

            //zapisujemy i zwracamy czy zapytanie przebiegło pomyslnie
            return DbContext.SaveChanges() > 0;
        }
        /// <summary>
        /// metoda pozwalajaca zmienic haslo pacjenta w bazie danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool ChangePassword(string firstName, string lastName, string password, string newPassword)
        {
            //sprawdzamy czy istnieje taki użytkownik w bazie, ktorego chcemy usunac
            Patient patientToEdit = DbContext.Patients.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName && p.Password == password);
            if (patientToEdit == null)
                return false;

            //zmieniamy haslo
            patientToEdit.Password = newPassword;

            //zapisujemy i zwracamy czy zapytanie przebiegło pomyslnie
            return DbContext.SaveChanges() > 0;
        }
    }
}
