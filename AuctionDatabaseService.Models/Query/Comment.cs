using System;
using System.Runtime.Serialization;

namespace AuctionDatabaseService.Models.Query
{
    [DataContract]
    public class Comment
    {
        public Comment()
        {
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public DateTime PostingDate { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int AuctionId { get; set; }
    }
}
