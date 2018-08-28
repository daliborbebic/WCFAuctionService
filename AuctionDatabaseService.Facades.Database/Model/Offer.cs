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
        public int Id { get; set; }

        public double Value { get; set; }

        public DateTime OfferedOn { get; set; }

        public virtual Auction Auction { get; set; }

        public virtual User User { get; set; }
    }
}
