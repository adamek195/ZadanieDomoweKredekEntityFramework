using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.ViewModels;
using System.Collections.Generic;

namespace AdamBednorzZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// interfejs gdzie zadeklarowane sa wszystkie metody do obslugi tabeli z lekarstwami
    /// </summary>
    public interface IMedicinesRepository
    {
        /// <summary>
        /// definicja metody zwracajacej wszystkie rekordy z tabeli lekarstw
        /// </summary>
        /// <returns></returns>
        List<Medicine> GetMedicines();
        /// <summary>
        /// definicja metody pozwalajacej pobrac zmapowanye lekarstwa
        /// </summary>
        /// <returns></returns>
        List<MedicineViewModel> GetMedicineViewModels();
    }
}
