using System.Collections.Generic;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Contracts
{
    public interface IItemRepository
    {
        Item Add(Item entity);

        void AddRange(IEnumerable<Item> entities);

        Item GetById(int id);

        IEnumerable<Item> GetAll();

        Item Update(Item entity);

        void Remove(Item entity);

        void RemoveRange(IEnumerable<Item> entities);
    }
}
