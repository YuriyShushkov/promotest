using AutoMapper;
using PromoTest.Server.Contracts.Dtos;
using PromoTest.Server.Storage.Models;

namespace PromoTest.Server.Services
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Province, ProvinceDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
