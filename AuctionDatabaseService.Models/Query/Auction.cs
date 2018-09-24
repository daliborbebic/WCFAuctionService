using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuctionDatabaseService.Models.Query
{
    [DataContract]
    public class Auction
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime StartDateTime { get; set; }

        [DataMember]
        public DateTime EndDateTime { get; set; }

        [DataMember]
        public int Duration { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public double StartingPrice { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public byte[] Image { get; set; }

        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public List<Offer> Offers { get; set; }

        [DataMember]
        public List<Comment> Comments { get; set; }
    }
}
