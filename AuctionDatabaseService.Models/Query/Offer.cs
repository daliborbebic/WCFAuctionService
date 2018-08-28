using System;
using System.Runtime.Serialization;

namespace AuctionDatabaseService.Models.Query
{
    [DataContract]
    public class Offer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public double Value { get; set; }

        [DataMember]
        public DateTime OfferedOn { get; set; }

        [DataMember]
        public Auction Auction { get; set; }

        [DataMember]
        public User User { get; set; }
    }
}
