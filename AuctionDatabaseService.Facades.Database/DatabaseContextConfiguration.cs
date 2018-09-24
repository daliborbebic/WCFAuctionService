using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace AuctionDatabaseService.Facades.Database
{
    class DatabaseContextConfiguration : DbConfiguration
    {
        public DatabaseContextConfiguration()
        {
            SetDatabaseInitializer(new DropCreateDatabaseIfModelChanges<DatabaseContext>());
            SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
        }
    }
}
