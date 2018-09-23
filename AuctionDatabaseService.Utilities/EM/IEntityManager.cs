using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Contracts;

namespace AuctionDatabaseService.Utilities.EM
{
    public interface IEntityManager
    {

        IUserService UserService { get; }

        IAuctionService AuctionService { get; }

        ICommentService CommentService { get; }

        ICategoryService CategoryService { get; }

        IOfferService OfferService { get; }

        T Add<T, S>(T entity);

        void AddRange<T, S>(IEnumerable<T> entities);

        void Remove<T, S>(T entity);

        void RemoveRange<T, S>(IEnumerable<T> entities);

        T GetById<T, S>(int entityId);

        List<T> GetAll<T, S>();

        T Update<T, S>(T entity);
    }
}
