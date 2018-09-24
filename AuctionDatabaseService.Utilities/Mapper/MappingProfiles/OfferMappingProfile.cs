using AuctionDatabaseService.Models.Query;
using AutoMapper;
using Bl = AuctionDatabaseService.BusinessLayer.Model;
using Fa = AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Utilities.AutoMapper.MappingProfiles
{
    public class OfferMappingProfile : Profile
    {
        public OfferMappingProfile()
        {
            CreateMap<Bl.Offer, Offer>().ReverseMap();
            CreateMap<Bl.Offer, Fa.Offer>()
                .ForMember(dest => dest.OfferId, conf => conf.MapFrom(src => src.Id))
                .ReverseMap();
        }
    }
}