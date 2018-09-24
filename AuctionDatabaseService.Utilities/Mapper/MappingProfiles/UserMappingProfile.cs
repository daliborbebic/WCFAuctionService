using AuctionDatabaseService.Models.Query;
using AutoMapper;
using Bl = AuctionDatabaseService.BusinessLayer.Model;
using Fa = AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Utilities.AutoMapper.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<Bl.User, User>().ReverseMap();
            CreateMap<Bl.User, Fa.User>()
                .ForMember(dest => dest.UserId, conf => conf.MapFrom(src => src.Id))
                .ReverseMap();
        }
    }
}