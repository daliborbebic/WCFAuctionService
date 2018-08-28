namespace AuctionDatabaseService.BusinessLayer.Model
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public Category Category { get; set; }

        public Auction Auction { get; set; }
    }
}
