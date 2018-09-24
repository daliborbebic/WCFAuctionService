using System;

namespace AuctionDatabaseService.BusinessLayer.Model
{
    public class Comment
    {
        public Comment()
        {
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime PostingDate { get; set; }

        public int UserId { get; set; }

        public int AuctionId { get; set; }
    }
}
