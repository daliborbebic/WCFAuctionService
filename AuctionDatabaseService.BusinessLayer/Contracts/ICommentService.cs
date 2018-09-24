using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Model;

namespace AuctionDatabaseService.BusinessLayer.Contracts
{
    public interface ICommentService : IService<Comment>
    {
        List<Comment> GetByUser(int userId);
        List<Comment> GetByAuction(int auctionId);
    }
}
