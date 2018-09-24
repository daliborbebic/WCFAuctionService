using System.Collections.Generic;
using System.Linq;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Repositories
{
    public class OfferRepository : BaseRepository<Offer>, IOfferRepository
    {
        public OfferRepository() : base()
        {

        }

        public List<Offer> GetByAuction(int auctionId)
        {
            return _dbSet.Where(offer => offer.AuctionId == auctionId).ToList();
        }

        public List<Offer> GetByUser(int userId)
        {
            return _dbSet.Where(offer => offer.UserId == userId).ToList();
        }
    }
}
