using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Model;

namespace AuctionDatabaseService.BusinessLayer.Contracts
{
    public interface IOfferService : IService<Offer>
    {
        List<Offer> GetByAuction(int auctionId);
        List<Offer> GetByUser(int userId);
    }
}
