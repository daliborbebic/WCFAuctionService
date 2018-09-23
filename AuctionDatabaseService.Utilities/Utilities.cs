using AuctionDatabaseService.BusinessLayer;
using AuctionDatabaseService.Utilities.EM;
using AuctionDatabaseService.Utilities.MapperUtils;

namespace AuctionDatabaseService.Utilities
{
    public static class Utilities
    {
        public static void ConfigureAutoMapper()
        {
            AutoMapperUtilities.ConfigureAutoMapper();
        }

        public static IEntityManager CreateEntityManager()
        {
            var em = new EntityManager(new UserService(), new AuctionService(), new CommentService(), new CategoryService(), new OfferService());
            return em;
        }
    }
}
