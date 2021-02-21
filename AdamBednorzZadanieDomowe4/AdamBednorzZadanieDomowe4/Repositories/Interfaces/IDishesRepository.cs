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
    /// interfejs gdzie zadeklarowane sa wszystkie metody do obslugi tabeli z daniami
    /// </summary>
    public interface IDishesRepository
    {
        /// <summary>
        /// definicja metody zwracajacej wszystkie rekordy z tabeli dania
        /// </summary>
        /// <returns></returns>
        List<Dish> GetDishes();
        /// <summary>
        /// definicja metody pozwalajacej pobrac zmapowane dania
        /// </summary>
        /// <returns></returns>
        List<DishViewModel> GetDishViewModels();
    }
}
