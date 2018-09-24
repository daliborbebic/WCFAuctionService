using System.Collections.Generic;
using System.Linq;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Repositories
{
    public class AuctionRepository : BaseRepository<Auction>, IAuctionRepository
    {
        public AuctionRepository() : base()
        {

        }

        public List<Auction> GetByCategory(int categoryId)
        {
            return _dbSet.Where(auction => auction.CategoryId == categoryId).ToList();
        }

        public List<Auction> GetByUser(int userId)
        {
            return _dbSet.Where(auction => auction.UserId == userId).ToList();
        }
    }
}
