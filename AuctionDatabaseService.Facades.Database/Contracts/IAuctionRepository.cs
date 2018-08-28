using System.Collections.Generic;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Contracts
{
    public interface IAuctionRepository
    {
        Auction Add(Auction entity);

        void AddRange(IEnumerable<Auction> entities);

        Auction GetById(int id);

        IEnumerable<Auction> GetAll();

        Auction Update(Auction entity);

        void Remove(Auction entity);

        void RemoveRange(IEnumerable<Auction> entities);
    }
}
