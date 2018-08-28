using System.Collections.Generic;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Contracts
{
    public interface IUserRepository
    {
        User Add(User entity);

        void AddRange(IEnumerable<User> entities);

        User GetById(int id);

        IEnumerable<User> GetAll();

        User Update(User entity);

        void Remove(User entity);

        void RemoveRange(IEnumerable<User> entities);

        bool IsEmailTaken(string emailAddress);

        bool VerifyLoginInformation(string emailAddress, string password);
    }
}
