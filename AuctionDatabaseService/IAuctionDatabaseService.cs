using System.Collections.Generic;
using System.ServiceModel;
using AuctionDatabaseService.Models.Query;

namespace AuctionDatabaseService
{
    [ServiceContract]
    public interface IAuctionDatabaseService
    {
        [OperationContract]
        Auction CreateAuction(Auction auction);

        [OperationContract]
        void CreateAuctions(IEnumerable<Auction> auctions);

        [OperationContract]
        Auction GetAuctionById(int auctionId);

        [OperationContract]
        List<Auction> GetAllAuctions();

        [OperationContract]
        Auction UpdateAuction(Auction auction);

        [OperationContract]
        void DeleteAuction(Auction auction);

        [OperationContract]
        void DeleteAuctions(IEnumerable<Auction> auctions);

        [OperationContract]
        Category CreateCategory(Category category);

        [OperationContract]
        void CreateCategories(IEnumerable<Category> categories);

        [OperationContract]
        Category GetCategoryById(int categoryId);

        [OperationContract]
        List<Category> GetAllCategories();

        [OperationContract]
        Category UpdateCategory(Category category);

        [OperationContract]
        void DeleteCategory(Category category);

        [OperationContract]
        void DeleteCategories(IEnumerable<Category> categories);

        [OperationContract]
        Comment CreateComment(Comment comment);

        [OperationContract]
        void CreateComments(IEnumerable<Comment> comments);

        [OperationContract]
        Comment GetCommentById(int commentId);

        [OperationContract]
        List<Comment> GetAllComments();

        [OperationContract]
        Comment UpdateComment(Comment comment);

        [OperationContract]
        void DeleteComment(Comment comment);

        [OperationContract]
        void DeleteComments(IEnumerable<Comment> comments);

        [OperationContract]
        User CreateUser(User user);

        [OperationContract]
        void CreateUsers(IEnumerable<User> users);

        [OperationContract]
        User GetUserById(int userId);

        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        User UpdateUser(User user);

        [OperationContract]
        void DeleteUser(User user);

        [OperationContract]
        void DeleteUsers(IEnumerable<User> users);

        [OperationContract]
        Offer CreateOffer(Offer offer);

        [OperationContract]
        void CreateOffers(IEnumerable<Offer> offers);

        [OperationContract]
        Offer GetOfferById(int offerId);

        [OperationContract]
        List<Offer> GetAllOffers();

        [OperationContract]
        Offer UpdateOffer(Offer offer);

        [OperationContract]
        void DeleteOffer(Offer offer);

        [OperationContract]
        void DeleteOffers(IEnumerable<Offer> offers);

        [OperationContract]
        bool IsEmailTaken(string emailAddress);

        [OperationContract]
        bool VerifyLoginInformation(string emailAddress, string password);

        [OperationContract]
        List<Comment> GetCommentsByAuction(int AuctionId);

        [OperationContract]
        List<Auction> GetAuctionsByUser(int userId);

        [OperationContract]
        List<Comment> GetCommentsByUser(int userId);

        [OperationContract]
        List<Offer> GetOffersByUser(int userId);

        [OperationContract]
        List<Offer> GetOffersByAuction(int auctionId);

        [OperationContract]
        List<Auction> GetAuctionsByCategory(int categoryId);
    }
}
