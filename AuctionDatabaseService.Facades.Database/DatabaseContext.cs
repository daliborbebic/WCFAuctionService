using System;
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

        public DbSet<Auction> Auctions { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }

            modelBuilder.Entity<Comment>()
                .HasRequired(x => x.User)
                .WithMany(y => y.Comments)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offer>()
                .HasRequired(x => x.User)
                .WithMany(y => y.Offers)
                .WillCascadeOnDelete(false);
        }
    }
}
