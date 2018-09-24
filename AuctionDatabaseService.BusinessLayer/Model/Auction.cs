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

        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int Duration { get; set; }

        public double StartingPrice { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public ICollection<Offer> Offers { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
