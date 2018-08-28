using System.Linq;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() : base()
        {

        }

        public bool IsEmailTaken(string emailAddress)
        {
            return _context.Users.Any(user => user.EmailAddress == emailAddress);
        }


        public bool VerifyLoginInformation(string emailAddress, string password)
        {
            return _context.Users.Any(user => user.EmailAddress == emailAddress && user.Password == password);
        }
    }
}
