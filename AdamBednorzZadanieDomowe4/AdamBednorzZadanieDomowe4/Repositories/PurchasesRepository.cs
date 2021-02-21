using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.Repositories.Interfaces;
using AdamBednorzZadanieDomowe4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe4.Repositories
{
    public class PurchasesRepository : Repository, IPurchasesRepository
    {
        /// <summary>
        /// metoda pozwalajaca pobrac wszystkie rekordy z tabeli zamówień lekarstw
        /// </summary>
        /// <returns></returns>
        public List<Purchase> GetPurchases()
        {
            return DbContext.Purchases.ToList();
        }
        /// <summary>
        /// metoda pozwalajaca pobrac wszystkie zmapowane zamówienia
        /// </summary>
        /// <returns></returns>
        public List<PurchaseViewModel> GetPurchaseViewModels()
        {
            List<Purchase> purchases = DbContext.Purchases.ToList();
            return Mapper.Map<List<Purchase>, List<PurchaseViewModel>>(purchases);
        }

        public bool AddPurchase(string firstName, string lastName, string password, string medicineName)
        {
            //szukamy pacjenta i lekarstwa
            Patient patient = DbContext.Patients.SingleOrDefault(p => p.FirstName == firstName && p.LastName == lastName && p.Password == password);
            Medicine medicine = DbContext.Medicines.SingleOrDefault(m => m.MedicineName == medicineName);
            //jesli nie ma takiego pacjenta lub lekarstwa w bazie zwroc falsz
            if (patient == null || medicine == null)
                return false;

            //dodajemy nowe zamowienie
            Purchase purchaseToAdd = new Purchase()
            {
                PatientId = patient.Id,
                MedicineId = medicine.Id
            };

            //dodajemy zamowienie do bazy
            DbContext.Purchases.Add(purchaseToAdd);

            //zwracamy true jesli wszystko przebieglo pomyslnie
            return DbContext.SaveChanges() > 0;
        }
    }
}
