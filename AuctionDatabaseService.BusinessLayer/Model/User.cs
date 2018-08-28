using System.Collections.Generic;

namespace AuctionDatabaseService.BusinessLayer.Model
{
    public class User
    {
        public User()
        {
            Comments = new List<Comment>();
            Auctions = new List<Auction>();
            Offers = new List<Offer>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string PostalCode { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Auction> Auctions { get; set; }

        public ICollection<Offer> Offers { get; set; }
    }
}
