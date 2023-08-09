using AutoMapper;
using UdemyAuthServer.Core.Dtos;
using UdemyAuthServer.Core.Models;

namespace UdemyAuthServer.Service.AutoMapper
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}