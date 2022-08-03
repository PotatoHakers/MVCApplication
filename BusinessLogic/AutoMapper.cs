

using Model;
using Model.ModelDTO;
using AutoMapper;

namespace BusinessLogic
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Car, CarDTO>().ReverseMap();
            CreateMap<Owner, OwnerDTO>().ReverseMap();
            CreateMap<Owner, LoginDTO>().ReverseMap();
        }

    }
}
