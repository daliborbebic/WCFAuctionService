using System.Collections.Generic;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Contracts
{
    public interface IOfferRepository
    {
        Offer Add(Offer entity);

        void AddRange(IEnumerable<Offer> entities);

        Offer GetById(int id);

        IEnumerable<Offer> GetAll();

        Offer Update(Offer entity);

        void Remove(Offer entity);

        void RemoveRange(IEnumerable<Offer> entities);

        List<Offer> GetByUser(int userId);

        List<Offer> GetByAuction(int auctionId);
    }
}
