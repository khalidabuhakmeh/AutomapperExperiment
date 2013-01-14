using AutoMapper;
using AutoMapperExperiment.Models.Objects;
using AutoMapperExperiment.Models.ViewModels;

namespace AutoMapperExperiment
{
    public static class MapConfig
    {
        public static void Initialize()
        {
            Map_Person_To_IndexViewModel();
            Map_Car_To_IndexViewModel();
        }


        private static void Map_Person_To_IndexViewModel()
        {
            Mapper.CreateMap<Person, IndexViewModel>()
                .ForMember(m => m.Name, s => s.MapFrom(i => i.Name))
                .ForMember(m => m.AddressCity, s => s.MapFrom(i => i.Address.City))
                .ForMember(m => m.AddressStreet, s => s.MapFrom(i => i.Address.Street));
        }

        private static void Map_Car_To_IndexViewModel()
        {
            Mapper.CreateMap<Car, IndexViewModel>()
                  .ForMember(m => m.CarColor, s => s.MapFrom(i => i.Color))
                  .ForMember(m => m.CarMake, s => s.MapFrom(i => i.Make))
                  .ForMember(m => m.CarModel, s => s.MapFrom(i => i.Model));
        }
    }
}