using System;
using System.Collections.Generic;

namespace AuctionDatabaseService.BusinessLayer.Model
{
    public class Auction
    {
        public Auction()
        {
            Comments = new List<Comment>();
            Offers = new List<Offer>();
        }

        public int Id { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int Duration { get; set; }

        public double StartingPrice { get; set; }

        public Item Item { get; set; }

        public User Author { get; set; }

        public ICollection<Offer> Offers { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
