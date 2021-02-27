using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.ViewModels;
using System.Collections.Generic;

namespace AdamBednorzZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// interfejs gdzie zadeklarowane sa wszystkie metodydo komunikacji z baza danych zamowień
    /// </summary>
    public interface IOrdersRepository
    {
        /// <summary>
        /// definicja metody zwracajacej wszystkie rekordy z tabeli zamówień
        /// </summary>
        /// <returns></returns>
        List<Order> GetOrders();
        /// <summary>
        /// definicja metody pozwalajacej pobrac zmapowane zamowienia
        /// </summary>
        /// <returns></returns>
        List<OrderViewModel> GetOrderViewModels();
        /// <summary>
        /// definicja metody do dodawania zamowien
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="dishName"></param>
        /// <returns></returns>
        bool AddOrder(string firstName, string lastName, string password, string dishName);
    }
}
