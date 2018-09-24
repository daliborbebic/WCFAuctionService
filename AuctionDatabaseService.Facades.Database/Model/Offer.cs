using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionDatabaseService.Facades.Database.Model
{
    [Table("Offers")]
    public class Offer
    {
        public Offer()
        {

        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OfferId { get; set; }

        public double Value { get; set; }

        public DateTime OfferedOn { get; set; }

        public int AuctionId { get; set; }

        [ForeignKey("AuctionId")]
        public virtual Auction Auction { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
