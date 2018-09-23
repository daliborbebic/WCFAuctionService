using System.Collections.Generic;
using System.ServiceModel;
using AuctionDatabaseService.Models.Query;
using AuctionDatabaseService.Utilities.EM;
using Bl = AuctionDatabaseService.BusinessLayer.Model;

namespace AuctionDatabaseService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class AuctionDatabaseService : IAuctionDatabaseService
    {
        private readonly IEntityManager _entityManager;

        public AuctionDatabaseService()
        {
            Utilities.Utilities.ConfigureAutoMapper();
            _entityManager = Utilities.Utilities.CreateEntityManager();
        }

        #region BaseOperations

        #region Creates
        public Auction CreateAuction(Auction auction)
        {
            return _entityManager.Add<Auction, Bl.Auction>(auction);
        }

        public void CreateAuctions(IEnumerable<Auction> auctions)
        {
            _entityManager.AddRange<Auction, Bl.Auction>(auctions);
        }

        public void CreateCategories(IEnumerable<Category> categories)
        {
            _entityManager.AddRange<Category, Bl.Category>(categories);
        }

        public Category CreateCategory(Category category)
        {
            return _entityManager.Add<Category, Bl.Category>(category);
        }

        public Comment CreateComment(Comment comment)
        {
            return _entityManager.Add<Comment, Bl.Comment>(comment);
        }

        public void CreateComments(IEnumerable<Comment> comments)
        {
            _entityManager.AddRange<Comment, Bl.Comment>(comments);
        }

        public Offer CreateOffer(Offer offer)
        {
            return _entityManager.Add<Offer, Bl.Offer>(offer);
        }

        public void CreateOffers(IEnumerable<Offer> offers)
        {
            _entityManager.AddRange<Offer, Bl.Offer>(offers);
        }

        public User CreateUser(User user)
        {
            return _entityManager.Add<User, Bl.User>(user);
        }

        public void CreateUsers(IEnumerable<User> users)
        {
            _entityManager.AddRange<User, Bl.User>(users);
        }

        #endregion Creates

        #region Deletes
        public void DeleteAuction(Auction auction)
        {
            _entityManager.Remove<Auction, Bl.Auction>(auction);
        }

        public void DeleteAuctions(IEnumerable<Auction> auctions)
        {
            _entityManager.RemoveRange<Auction, Bl.Auction>(auctions);
        }

        public void DeleteCategories(IEnumerable<Category> categories)
        {
            _entityManager.RemoveRange<Category, Bl.Category>(categories);
        }

        public void DeleteCategory(Category category)
        {
            _entityManager.Remove<Category, Bl.Category>(category);
        }

        public void DeleteComment(Comment comment)
        {
            _entityManager.Remove<Comment, Bl.Comment>(comment);
        }

        public void DeleteComments(IEnumerable<Comment> comments)
        {
            _entityManager.RemoveRange<Comment, Bl.Comment>(comments);
        }

        public void DeleteOffer(Offer offer)
        {
            _entityManager.Remove<Offer, Bl.Offer>(offer);
        }

        public void DeleteOffers(IEnumerable<Offer> offers)
        {
            _entityManager.RemoveRange<Offer, Bl.Offer>(offers);
        }

        public void DeleteUser(User user)
        {
            _entityManager.Remove<User, Bl.User>(user);
        }

        public void DeleteUsers(IEnumerable<User> users)
        {
            _entityManager.RemoveRange<User, Bl.User>(users);
        }

        #endregion Deletes

        #region GetAll
        public List<Auction> GetAllAuctions()
        {
            return _entityManager.GetAll<Auction, Bl.Auction>();
        }

        public List<Category> GetAllCategories()
        {
            return _entityManager.GetAll<Category, Bl.Category>();
        }

        public List<Comment> GetAllComments()
        {
            return _entityManager.GetAll<Comment, Bl.Comment>();
        }

        public List<Offer> GetAllOffers()
        {
            return _entityManager.GetAll<Offer, Bl.Offer>();
        }

        public List<User> GetAllUsers()
        {
            return _entityManager.GetAll<User, Bl.User>();
        }

        #endregion GetAll

        #region GetById
        public Auction GetAuctionById(int auctionId)
        {
            return _entityManager.GetById<Auction, Bl.Auction>(auctionId);
        }

        public Category GetCategoryById(int categoryId)
        {
            return _entityManager.GetById<Category, Bl.Category>(categoryId);
        }

        public Comment GetCommentById(int commentId)
        {
            return _entityManager.GetById<Comment, Bl.Comment>(commentId);
        }

        public Offer GetOfferById(int offerId)
        {
            return _entityManager.GetById<Offer, Bl.Offer>(offerId);
        }

        public User GetUserById(int userId)
        {
            return _entityManager.GetById<User, Bl.User>(userId);
        }

        #endregion GetById

        #region Update

        public Auction UpdateAuction(Auction auction)
        {
            return _entityManager.Update<Auction, Bl.Auction>(auction);
        }

        public Category UpdateCategory(Category category)
        {
            return _entityManager.Update<Category, Bl.Category>(category);
        }

        public Comment UpdateComment(Comment comment)
        {
            return _entityManager.Update<Comment, Bl.Comment>(comment);
        }

        public Offer UpdateOffer(Offer offer)
        {
            return _entityManager.Update<Offer, Bl.Offer>(offer);
        }

        public User UpdateUser(User user)
        {
            return _entityManager.Update<User, Bl.User>(user);
        }
        #endregion Update

        #endregion BaseOperations

        public bool IsEmailTaken(string emailAddress)
        {
            return _entityManager.UserService.IsEmailTaken(emailAddress);
        }

        public bool VerifyLoginInformation(string emailAddress, string password)
        {
            return _entityManager.UserService.VerifyLoginInformation(emailAddress, password);
        }
    }
}
