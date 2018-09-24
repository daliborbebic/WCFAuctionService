using System.Collections.Generic;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Contracts
{
    public interface ICommentRepository
    {
        Comment Add(Comment entity);

        void AddRange(IEnumerable<Comment> entities);

        Comment GetById(int id);

        IEnumerable<Comment> GetAll();

        Comment Update(Comment entity);

        void Remove(Comment entity);

        void RemoveRange(IEnumerable<Comment> entities);

        List<Comment> GetByAuction(int auctionId);

        List<Comment> GetByUser(int userId);
    }
}
