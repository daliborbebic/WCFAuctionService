using System.Collections.Generic;

namespace AuctionDatabaseService.BusinessLayer.Contracts
{
    public interface IService<T>
    {
        T Add(T entity);

        void AddRange(IEnumerable<T> entities);

        T Update(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        T GetById(int id);

        IEnumerable<T> GetAll();
    }
}
