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
        public int CommentId { get; set; }

        public string Content { get; set; }

        public DateTime PostingDate { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int AuctionId { get; set; }

        [ForeignKey("AuctionId")]
        public virtual Auction Auction { get; set; }
    }
}
