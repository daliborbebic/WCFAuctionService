using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuctionDatabaseService.Models.Query
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public List<Comment> Comments { get; set; }

        [DataMember]
        public List<Auction> Auctions { get; set; }

        [DataMember]
        public List<Offer> Offers { get; set; }
    }
}
