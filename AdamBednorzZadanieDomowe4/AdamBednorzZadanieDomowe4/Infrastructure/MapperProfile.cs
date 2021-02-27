using AdamBednorzZadanieDomowe4.Models.Entities;
using AdamBednorzZadanieDomowe4.ViewModels;
using AutoMapper;

namespace AdamBednorzZadanieDomowe4.Infrastructure
{
    class MapperProfile : Profile
    {
        public MapperProfile()
        {

            //mapa na wiew model wizyt tlumacząca skąd mają być pobierane dane do nowych zmiennych
            CreateMap<Visit, VisitViewModel>()
                .ForMember(v => v.PatientFirstName, opt => opt.MapFrom(src => src.Patient.FirstName))
                .ForMember(v => v.PatientLastName, opt => opt.MapFrom(src => src.Patient.LastName))
                .ForMember(v => v.TypeDoctor, opt => opt.MapFrom(src => src.Doctor.Type));

            CreateMap<Order, OrderViewModel>()
                .ForMember(o => o.PatientFirstName, opt => opt.MapFrom(src => src.Patient.FirstName))
                .ForMember(o => o.PatientLastName, opt => opt.MapFrom(src => src.Patient.LastName))
                .ForMember(o => o.OrderDish, opt => opt.MapFrom(src => src.Dish.DishName));

            CreateMap<Purchase, PurchaseViewModel>()
               .ForMember(p => p.PatientFirstName, opt => opt.MapFrom(src => src.Patient.FirstName))
               .ForMember(p => p.PatientLastName, opt => opt.MapFrom(src => src.Patient.LastName))
               .ForMember(p => p.PurchaseMedicine, opt => opt.MapFrom(src => src.Medicine.MedicineName));

            CreateMap<Doctor, DoctorViewModel>()
               .ForMember(d => d.TypeDoctor, opt => opt.MapFrom(src => src.Type))
               .ForMember(d => d.DateDoctor, opt => opt.MapFrom(src => src.Date));

            CreateMap<Dish, DishViewModel>()
               .ForMember(d => d.DishName, opt => opt.MapFrom(src => src.DishName))
               .ForMember(d => d.PriceDish, opt => opt.MapFrom(src => src.Price));

            CreateMap<Medicine, MedicineViewModel>()
              .ForMember(m => m.MedicineName, opt => opt.MapFrom(src => src.MedicineName))
              .ForMember(m => m.PriceMedicine, opt => opt.MapFrom(src => src.Price));
        }
    }
}
