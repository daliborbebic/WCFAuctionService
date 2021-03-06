﻿using AuctionDatabaseService.Models.Query;
using AutoMapper;
using System;
using Bl = AuctionDatabaseService.BusinessLayer.Model;
using Fa = AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Utilities.AutoMapper.MappingProfiles
{
    public class AuctionMappingProfile : Profile
    {
        public AuctionMappingProfile()
        {
            CreateMap<Bl.Auction, Auction>()
                .ForMember(dest => dest.IsActive, conf => conf.ResolveUsing(src => src.EndDateTime > DateTime.Now));

            CreateMap<Auction, Bl.Auction>();

            CreateMap<Fa.Auction, Bl.Auction>()
                .ForMember(dest => dest.Id, conf => conf.MapFrom(src => src.AuctionId))
                .ReverseMap();
        }
    }
}