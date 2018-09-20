using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuctionDatabaseService.Models.Query
{
    [DataContract]
    public class Item
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public byte[] Image { get; set; }

        [DataMember]
        public Category Category { get; set; }

        [DataMember]
        public Auction Auction { get; set; }
    }
}
