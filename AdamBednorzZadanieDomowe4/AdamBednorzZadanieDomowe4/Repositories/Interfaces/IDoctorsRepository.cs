using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// interfejs gdzie zadeklarowane sa wszystkie metody do obslugi tabeli z lekarzami
    /// </summary>
    public interface IDoctorsRepository
    {
        /// <summary>
        /// definicja metody zwracajacej wszystkie rekordy z tabeli lekarzy
        /// </summary>
        /// <returns></returns>
        List<Doctor> GetDoctors();
        /// <summary>
        /// definicja metody pozwalajacej pobrac zmapowanych lekarzy
        /// </summary>
        /// <returns></returns>
        List<DoctorViewModel> GetDoctorViewModels();
    }
}
