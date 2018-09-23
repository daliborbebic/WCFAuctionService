using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuctionDatabaseService.Models.Query
{
    [DataContract]
    public class Category
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<Auction> Auctions { get; set; }
    }
}
