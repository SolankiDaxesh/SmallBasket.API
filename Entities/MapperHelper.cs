using AutoMapper;
using SmallBasket.API.Entities.User;
using SmallBasket.API.Model;

namespace SmallBasket.API.Entities
{
    public class MapperHelper : Profile
    {
        public MapperHelper()
        {
            CreateMap<Users, Users_RM>().ReverseMap();
        }
    }
}
