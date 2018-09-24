using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Model;

namespace AuctionDatabaseService.BusinessLayer.Contracts
{
    public interface IAuctionService : IService<Auction>
    {
        List<Auction> GetByCategory(int categoryId);
        List<Auction> GetByUser(int userId);
    }
}
