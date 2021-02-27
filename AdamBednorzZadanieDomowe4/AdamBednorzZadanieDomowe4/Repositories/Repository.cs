using AdamBednorzZadanieDomowe4.Infrastructure;
using AdamBednorzZadanieDomowe4.Models;
using AutoMapper;

namespace AdamBednorzZadanieDomowe4.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna mająca zmienne i/lub metody, które każde repozytorium powinno zawierać
    /// </summary>
    public abstract class Repository
    {
        //zmienna przechowujaca 
        protected readonly DataBaseContext DbContext = new DataBaseContext();

        //zmienna konfiguracji mappera
        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));
        //zmienna mappera
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
    }
}
