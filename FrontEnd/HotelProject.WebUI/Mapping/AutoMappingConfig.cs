using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMappingConfig:Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
        }
    }
}
