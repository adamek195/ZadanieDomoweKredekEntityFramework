using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.ViewModels;
using System.Collections.Generic;

namespace AdamBednorzZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// interfejs gdzie zadeklarowane sa metody do komunikacji z tabela zamowień lekarstw
    /// </summary>
    public interface IPurchasesRepository
    {
        /// <summary>
        /// definicja metody zwracajacej wszystkie rekordy z tabeli zamówień lekarstw
        /// </summary>
        /// <returns></returns>
        List<Purchase> GetPurchases();
        /// <summary>
        /// definicja metody pozwalajacej pobrac zmapowane zamowienia lekarstw
        /// </summary>
        /// <returns></returns>
        List<PurchaseViewModel> GetPurchaseViewModels();
        /// <summary>
        /// definicja metody pozwalajaca dodac nowe zamówienie lekarstwa do bazy
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="medicineName"></param>
        /// <returns></returns>
        bool AddPurchase(string firstName, string lastName, string password, string medicineName);
    }
}
