using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.Repositories.Interfaces;
using AdamBednorzZadanieDomowe4.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace AdamBednorzZadanieDomowe4.Repositories
{
    /// <summary>
    /// klasa do komunikacji z tabelą lekarsw z bazy danych
    /// </summary>
    class MedicinesRepository : Repository, IMedicinesRepository
    {
        /// <summary>
        /// metoda pobierajaca wszystkie lekarstwa z bazy danych
        /// </summary>
        /// <returns></returns>
        public List<Medicine> GetMedicines()
        {
            return DbContext.Medicines.ToList();
        }
        public List<MedicineViewModel> GetMedicineViewModels()
        {
            List<Medicine> medicines = DbContext.Medicines.ToList();
            return Mapper.Map<List<Medicine>, List<MedicineViewModel>>(medicines);
        }
    }
}
