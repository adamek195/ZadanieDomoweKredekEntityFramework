using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.ViewModels;
using System.Collections.Generic;

namespace AdamBednorzZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// interfejs gdzie zadeklarowane sa wszystkie metody do obslugi tabeli wizyt z bazy danych
    /// </summary>
    public interface IVisitsRepository
    {
        /// <summary>
        /// definicja metody zwracajacej wszystkie rekordy z tabeli wizyty
        /// </summary>
        /// <returns></returns>
        List<Visit> GetVisits();
        /// <summary>
        /// metoda pozwalajaca pobraz zmapowane rekordy
        /// </summary>
        /// <returns></returns>
        List<VisitViewModel> GetVisitViewModels();
        /// <summary>
        /// deklaracja metody pozwalajacej dodac do bazy danych wizyte
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="typeDoctor"></param>
        /// <returns></returns>
        bool AddVisit(string firstName, string lastName, string password, string typeDoctor);
    }
}
