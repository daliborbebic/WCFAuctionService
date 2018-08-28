using AuctionDatabaseService.BusinessLayer.Model;

namespace AuctionDatabaseService.BusinessLayer.Contracts
{
    public interface IUserService : IService<User>
    {
        bool IsEmailTaken(string emailAddress);

        bool VerifyLoginInformation(string emailAddress, string password);
    }
}
