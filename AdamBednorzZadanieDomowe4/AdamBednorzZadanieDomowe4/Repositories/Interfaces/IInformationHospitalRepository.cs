using AdamBednorzZadanieDomowe4.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// interfejs gdzie zadeklarowane sa metody do klasy obsulugujacej repozytorium
    /// z informacjami o szpitalu
    /// </summary>
    public interface IInformationHospitalRepository
    {
        /// <summary>
        /// metoda pobierajace ulice z tabeli gdzie sa informacje o szpitalu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetStreetById(int id);
        /// <summary>
        /// metoda pobierajaca nazwe szpitala z tabeli gdzie sa informacje o szpitalu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetHospitalNameById(int id);
        /// <summary>
        /// metoda pobierajaca numer telefonu z tabeli gdzie sa informacje o szpitalu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int GetPhoneNumberById(int id);
    }
}
