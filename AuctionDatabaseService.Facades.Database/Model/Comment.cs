using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionDatabaseService.Facades.Database.Model
{
    [Table("Comments")]
    public class Comment
    {
        public Comment()
        {
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime PostingDate { get; set; }

        public virtual User Author { get; set; }

        public virtual Auction Auction { get; set; }
    }
}
