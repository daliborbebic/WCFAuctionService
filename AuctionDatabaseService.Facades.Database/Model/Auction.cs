using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionDatabaseService.Facades.Database.Model
{
    [Table("Auctions")]
    public class Auction
    {
        public Auction()
        {
            Comments = new List<Comment>();
            Offers = new List<Offer>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int Duration { get; set; }

        public double StartingPrice { get; set; }

        public virtual User Author { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
