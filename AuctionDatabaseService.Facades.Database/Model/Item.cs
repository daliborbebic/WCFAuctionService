using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionDatabaseService.Facades.Database.Model
{
    [Table("Items")]
    public class Item
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), ForeignKey("Auction")]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public virtual Category Category { get; set; }

        public virtual Auction Auction { get; set; }
    }
}
