using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.Repositories.Interfaces;
using AdamBednorzZadanieDomowe4.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace AdamBednorzZadanieDomowe4.Repositories
{
    /// <summary>
    /// klasa do komunikacji z tabelą dań z bazy danych
    /// </summary>
    public class DishesRepository : Repository, IDishesRepository
    {
        /// <summary>
        /// metoda pobierajace wszystkie rekordy z tabeli dań
        /// </summary>
        /// <returns></returns>
        public List<Dish> GetDishes()
        {
            return DbContext.Dishes.ToList();
        }
        /// <summary>
        /// metoda pobierajace zmapowane dania 
        /// </summary>
        /// <returns></returns>
        public List<DishViewModel> GetDishViewModels()
        {
            List<Dish> dishes = DbContext.Dishes.ToList();
            return Mapper.Map<List<Dish>, List<DishViewModel>>(dishes);
        }
    }
}
