using AuctionDatabaseService.Models.Query;
using AutoMapper;
using Bl = AuctionDatabaseService.BusinessLayer.Model;
using Fa = AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Utilities.AutoMapper.MappingProfiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Bl.Category, Category>().ReverseMap();

            CreateMap<Bl.Category, Fa.Category>().ReverseMap();
        }
    }
}