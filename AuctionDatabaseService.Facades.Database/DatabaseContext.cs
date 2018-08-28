using System.Data.Entity;
using AuctionDatabaseService.Facades.Database.Model;

namespace AuctionDatabaseService.Facades.Database
{
    [DbConfigurationType(typeof(DatabaseContextConfiguration))]
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=AuctionDbConnectionString")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Auction> Auctions { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
