using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Contracts;
using AuctionDatabaseService.BusinessLayer.Model;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Repositories;
using AutoMapper;
using DbAuction = AuctionDatabaseService.Facades.Database.Model.Auction;

namespace AuctionDatabaseService.BusinessLayer
{
    public class AuctionService : IAuctionService
    {
        private readonly IAuctionRepository _auctionRepository;

        public AuctionService()
        {
            _auctionRepository = new AuctionRepository();
        }

        public AuctionService(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }

        public Auction Add(Auction auction)
        {
            var dbAuction = Mapper.Map<DbAuction>(auction);
            var createdDbAuction = _auctionRepository.Add(dbAuction);
            var createdAuction = Mapper.Map<Auction>(createdDbAuction);
            return createdAuction;
        }

        public void AddRange(IEnumerable<Auction> auctions)
        {
            IEnumerable<DbAuction> dbAuctions = Mapper.Map<IEnumerable<DbAuction>>(auctions);
            _auctionRepository.AddRange(dbAuctions);
        }

        public IEnumerable<Auction> GetAll()
        {
            var dbAuctions = _auctionRepository.GetAll();
            var auctions = Mapper.Map<IEnumerable<Auction>>(dbAuctions);
            return auctions;
        }

        public Auction GetById(int auctionId)
        {
            var dbAuction = _auctionRepository.GetById(auctionId);
            var auction = Mapper.Map<Auction>(dbAuction);
            return auction;
        }

        public void Remove(Auction auction)
        {
            var dbAuction = Mapper.Map<DbAuction>(auction);
            _auctionRepository.Remove(dbAuction);
        }

        public void RemoveRange(IEnumerable<Auction> auctions)
        {
            var dbAuctions = Mapper.Map<IEnumerable<DbAuction>>(auctions);
            _auctionRepository.RemoveRange(dbAuctions);
        }

        public Auction Update(Auction auction)
        {
            var dbAuction = Mapper.Map<DbAuction>(auction);
            var updatedDbAuction = _auctionRepository.Update(dbAuction);
            var updatedAuction = Mapper.Map<Auction>(updatedDbAuction);
            return updatedAuction;
        }
    }
}
