using System.Collections.Generic;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Contracts
{
    public interface ICategoryRepository
    {
        Category Add(Category entity);

        void AddRange(IEnumerable<Category> entities);

        Category GetById(int id);

        IEnumerable<Category> GetAll();

        Category Update(Category entity);

        void Remove(Category entity);

        void RemoveRange(IEnumerable<Category> entities);
    }
}
