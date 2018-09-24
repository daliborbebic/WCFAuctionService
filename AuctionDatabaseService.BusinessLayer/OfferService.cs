using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Contracts;
using AuctionDatabaseService.BusinessLayer.Model;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Repositories;
using AutoMapper;
using DbOffer = AuctionDatabaseService.Facades.Database.Model.Offer;

namespace AuctionDatabaseService.BusinessLayer
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;

        public OfferService()
        {
            _offerRepository = new OfferRepository();
        }

        public OfferService(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public Offer Add(Offer offer)
        {
            var dbOffer = Mapper.Map<DbOffer>(offer);
            var createdDbOffer = _offerRepository.Add(dbOffer);
            var createdOffer = Mapper.Map<Offer>(createdDbOffer);
            return createdOffer;
        }

        public void AddRange(IEnumerable<Offer> offers)
        {

            IEnumerable<DbOffer> dbOffers = Mapper.Map<IEnumerable<DbOffer>>(offers);
            _offerRepository.AddRange(dbOffers);
        }

        public IEnumerable<Offer> GetAll()
        {
            var dbOffers = _offerRepository.GetAll();
            var offers = Mapper.Map<IEnumerable<Offer>>(dbOffers);
            return offers;
        }

        public List<Offer> GetByAuction(int auctionId)
        {
            var dbOffers = _offerRepository.GetByAuction(auctionId);
            var offers = Mapper.Map<List<Offer>>(dbOffers);
            return offers;
        }

        public Offer GetById(int offerId)
        {
            var dbOffer = _offerRepository.GetById(offerId);
            var offers = Mapper.Map<Offer>(dbOffer);
            return offers;
        }

        public List<Offer> GetByUser(int userId)
        {
            var dbOffers = _offerRepository.GetByUser(userId);
            var offers = Mapper.Map<List<Offer>>(dbOffers);
            return offers;
        }

        public void Remove(Offer offer)
        {
            var dbOffer = Mapper.Map<DbOffer>(offer);
            _offerRepository.Remove(dbOffer);
        }

        public void RemoveRange(IEnumerable<Offer> offers)
        {
            var dbOffers = Mapper.Map<IEnumerable<DbOffer>>(offers);
            _offerRepository.RemoveRange(dbOffers);
        }

        public Offer Update(Offer offer)
        {
            var dbOffer = Mapper.Map<DbOffer>(offer);
            var updatedDbOffer = _offerRepository.Update(dbOffer);
            var updatedOffer = Mapper.Map<Offer>(updatedDbOffer);
            return updatedOffer;
        }
    }
}
