using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.Repositories.Interfaces;
using System.Linq;

namespace AdamBednorzZadanieDomowe4.Repositories
{
    /// <summary>
    /// klasa do obslugi tabeli z informacjami o szpitalu
    /// </summary>
    public class InformationHospitalRepository : Repository, IInformationHospitalRepository
    {
        /// <summary>
        /// meotda pobierajaca ulice z tabeli z informacjami o szpitalu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetStreetById(int id)
        {
           InformationHospital informationHospital = DbContext.InformationHospitals.SingleOrDefault(i => i.Id == id);
           return informationHospital.Street;
        }
        /// <summary>
        /// meotda pobierajaca nazwe szpitala z tabeli z informacjami o szpitalu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetHospitalNameById(int id)
        {
            InformationHospital informationHospital = DbContext.InformationHospitals.SingleOrDefault(i => i.Id == id);
            return informationHospital.HospitalName;
        }
        /// <summary>
        /// meotda pobierajaca numer telefonu z tabeli z informacjami o szpitalu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetPhoneNumberById(int id)
        {
            InformationHospital informationHospital = DbContext.InformationHospitals.SingleOrDefault(i => i.Id == id);
            return informationHospital.PhoneNumber;
        }
    }
}
