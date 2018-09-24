using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Contracts;
using AuctionDatabaseService.BusinessLayer.Model;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Repositories;
using AutoMapper;
using DbComment = AuctionDatabaseService.Facades.Database.Model.Comment;

namespace AuctionDatabaseService.BusinessLayer
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService()
        {
            _commentRepository = new CommentRepository();
        }

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Comment Add(Comment comment)
        {
            var dbComment = Mapper.Map<DbComment>(comment);
            var createdDbComment = _commentRepository.Add(dbComment);
            var createdComment = Mapper.Map<Comment>(createdDbComment);
            return createdComment;
        }

        public void AddRange(IEnumerable<Comment> comments)
        {

            IEnumerable<DbComment> dbComments = Mapper.Map<IEnumerable<DbComment>>(comments);
            _commentRepository.AddRange(dbComments);
        }

        public IEnumerable<Comment> GetAll()
        {
            var dbComments = _commentRepository.GetAll();
            var comments = Mapper.Map<IEnumerable<Comment>>(dbComments);
            return comments;
        }

        public List<Comment> GetByAuction(int auctionId)
        {
            var dbComments = _commentRepository.GetByAuction(auctionId);
            var comments = Mapper.Map<List<Comment>>(dbComments);
            return comments;
        }

        public Comment GetById(int commentId)
        {
            var dbComment = _commentRepository.GetById(commentId);
            var comments = Mapper.Map<Comment>(dbComment);
            return comments;
        }

        public List<Comment> GetByUser(int userId)
        {
            var dbComments = _commentRepository.GetByUser(userId);
            var comments = Mapper.Map<List<Comment>>(dbComments);
            return comments;
        }

        public void Remove(Comment comment)
        {
            var dbComment = Mapper.Map<DbComment>(comment);
            _commentRepository.Remove(dbComment);
        }

        public void RemoveRange(IEnumerable<Comment> comments)
        {
            var dbComments = Mapper.Map<IEnumerable<DbComment>>(comments);
            _commentRepository.RemoveRange(dbComments);
        }

        public Comment Update(Comment comment)
        {
            var dbComment = Mapper.Map<DbComment>(comment);
            var updatedDbComment = _commentRepository.Update(dbComment);
            var updatedComment = Mapper.Map<Comment>(updatedDbComment);
            return updatedComment;
        }
    }
}
