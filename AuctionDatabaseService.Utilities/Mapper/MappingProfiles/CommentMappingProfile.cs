using AuctionDatabaseService.Models.Query;
using AutoMapper;
using Bl = AuctionDatabaseService.BusinessLayer.Model;
using Fa = AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Utilities.AutoMapper.MappingProfiles
{
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile()
        {
            CreateMap<Bl.Comment, Comment>().ReverseMap();
            CreateMap<Bl.Comment, Fa.Comment>()
                .ForMember(dest => dest.CommentId, conf => conf.MapFrom(src => src.Id))
                .ReverseMap();
        }
    }
}