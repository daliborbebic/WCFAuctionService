using System.Collections.Generic;
using System.Linq;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository() : base()
        {
        }

        public List<Comment> GetByAuction(int auctionId)
        {
            return _dbSet.Where(comment => comment.AuctionId == auctionId).ToList();
        }

        public List<Comment> GetByUser(int userId)
        {
            return _dbSet.Where(comment => comment.UserId == userId).ToList();
        }
    }
}
