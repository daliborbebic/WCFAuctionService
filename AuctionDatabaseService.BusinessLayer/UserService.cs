using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Contracts;
using AuctionDatabaseService.BusinessLayer.Model;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Repositories;
using AutoMapper;
using DbUser = AuctionDatabaseService.Facades.Database.Model.User;

namespace AuctionDatabaseService.BusinessLayer
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Add(User user)
        {
            var dbUser = Mapper.Map<DbUser>(user);
            var createdDbUser = _userRepository.Add(dbUser);
            var createdUser = Mapper.Map<User>(createdDbUser);
            return createdUser;
        }

        public void AddRange(IEnumerable<User> users)
        {

            IEnumerable<DbUser> dbUsers = Mapper.Map<IEnumerable<DbUser>>(users);
            _userRepository.AddRange(dbUsers);
        }

        public IEnumerable<User> GetAll()
        {
            var dbUsers = _userRepository.GetAll();
            var users = Mapper.Map<IEnumerable<User>>(dbUsers);
            return users;
        }

        public User GetById(int userId)
        {
            var dbUser = _userRepository.GetById(userId);
            var users = Mapper.Map<User>(dbUser);
            return users;
        }

        public void Remove(User user)
        {
            var dbUser = Mapper.Map<DbUser>(user);
            _userRepository.Remove(dbUser);
        }

        public void RemoveRange(IEnumerable<User> users)
        {
            var dbUsers = Mapper.Map<IEnumerable<DbUser>>(users);
            _userRepository.RemoveRange(dbUsers);
        }

        public User Update(User user)
        {
            var dbUser = Mapper.Map<DbUser>(user);
            var updatedDbUser = _userRepository.Update(dbUser);
            var updatedUser = Mapper.Map<User>(updatedDbUser);
            return updatedUser;
        }

        public bool IsEmailTaken(string emailAddress)
        {
            return _userRepository.IsEmailTaken(emailAddress);
        }

        public bool VerifyLoginInformation(string emailAddress, string password)
        {
            return _userRepository.VerifyLoginInformation(emailAddress, password);
        }
    }
}
