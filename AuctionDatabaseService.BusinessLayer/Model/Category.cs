using System.Collections.Generic;

namespace AuctionDatabaseService.BusinessLayer.Model
{
    public class Category
    {
        public Category()
        {
            Auctions = new List<Auction>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Auction> Auctions { get; set; }
    }
}
