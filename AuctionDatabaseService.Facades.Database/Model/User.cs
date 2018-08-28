using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionDatabaseService.Facades.Database.Model
{
    [Table("Users")]
    public class User
    {
        public User()
        {
            Comments = new List<Comment>();
            Auctions = new List<Auction>();
            Offers = new List<Offer>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string PostalCode { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Auction> Auctions { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
