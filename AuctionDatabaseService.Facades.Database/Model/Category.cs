using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionDatabaseService.Facades.Database.Model
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            Auctions = new List<Auction>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Auction> Auctions { get; set; }
    }
}
