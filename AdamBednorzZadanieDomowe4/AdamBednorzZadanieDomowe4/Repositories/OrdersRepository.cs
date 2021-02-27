using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.Repositories.Interfaces;
using AdamBednorzZadanieDomowe4.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace AdamBednorzZadanieDomowe4.Repositories
{
    /// <summary>
    /// klasa do komunikacji z bazą danych zamówień
    /// </summary>
    public class OrdersRepository : Repository, IOrdersRepository
    {
        /// <summary>
        /// metoda pobierajaca wszystkie rekordy z tabeli zamówień
        /// </summary>
        /// <returns></returns>
        public List<Order> GetOrders()
        {
            return DbContext.Orders.ToList();
        }

        /// <summary>
        /// metoda pozwalajaca pobrac wszystkie zmapowane zamówienia
        /// </summary>
        /// <returns></returns>
        public List<OrderViewModel> GetOrderViewModels()
        {
            List<Order> orders = DbContext.Orders.ToList();
            return Mapper.Map<List<Order>, List<OrderViewModel>>(orders);
        }

        public bool AddOrder(string firstName, string lastName, string password, string dishName)
        {
            //szukamy pacjenta i dania
            Patient patient = DbContext.Patients.SingleOrDefault(p => p.FirstName == firstName && p.LastName == lastName && p.Password == password);
            Dish dish = DbContext.Dishes.SingleOrDefault(d => d.DishName == dishName);
            //jesli nie ma takiego pacjenta lub dania w bazie zwroc falsz
            if (patient == null || dish == null)
                return false;

            //dodajemy nowe zamowienie
            Order orderToAdd = new Order()
            {
                PatientId = patient.Id,
                DishId = dish.Id
            };

            //dodajemy zamowienie do bazy
            DbContext.Orders.Add(orderToAdd);

            //zwracamy true jesli wszystko przebieglo pomyslnie
            return DbContext.SaveChanges() > 0;
        }

    }
}
