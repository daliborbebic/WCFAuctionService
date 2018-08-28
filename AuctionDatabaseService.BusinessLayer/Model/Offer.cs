using System;

namespace AuctionDatabaseService.BusinessLayer.Model
{
    public class Offer
    {
        public Offer()
        {

        }

        public int Id { get; set; }

        public double Value { get; set; }

        public DateTime OfferedOn { get; set; }

        public Auction Auction { get; set; }

        public User User { get; set; }
    }
}
