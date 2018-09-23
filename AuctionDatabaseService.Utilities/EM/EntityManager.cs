using System;
using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Contracts;
using AuctionDatabaseService.BusinessLayer.Model;
using AutoMapper;

namespace AuctionDatabaseService.Utilities.EM
{
    public class EntityManager : IEntityManager
    {
        public EntityManager(IUserService userService,
            IAuctionService auctionService,
            ICommentService commentService,
            ICategoryService categoryService,
            IOfferService offerService)
        {
            UserService = userService;
            AuctionService = auctionService;
            CommentService = commentService;
            CategoryService = categoryService;
            OfferService = offerService;
        }

        #region Services

        public IUserService UserService { get; }

        public IAuctionService AuctionService { get; }

        public ICommentService CommentService { get; }

        public ICategoryService CategoryService { get; }

        public IOfferService OfferService { get; }

        #endregion Services

        #region BaseOperations

        public T Add<T, S>(T entity)
        {
            var service = GetService<S>();
            var blEntity = Mapper.Map<S>(entity);
            var createdBl = service.Add(blEntity);
            var createdEntity = Mapper.Map<T>(createdBl);
            return createdEntity;
        }

        public void AddRange<T, S>(IEnumerable<T> entities)
        {
            var service = GetService<S>();
            var blEntitites = Mapper.Map<List<S>>(entities);
            service.AddRange(blEntitites);
        }

        public void Remove<T, S>(T entity)
        {
            var service = GetService<S>();
            var blEntity = Mapper.Map<S>(entity);
            service.Remove(blEntity);
        }

        public void RemoveRange<T, S>(IEnumerable<T> entities)
        {
            var service = GetService<S>();
            var blEntitites = Mapper.Map<List<S>>(entities);
            service.RemoveRange(blEntitites);
        }

        public T GetById<T, S>(int entityId)
        {
            var service = GetService<S>();
            var blEntity = service.GetById(entityId);
            var entity = Mapper.Map<T>(blEntity);
            return entity;
        }

        public List<T> GetAll<T, S>()
        {
            var service = GetService<S>();
            var blEntities = service.GetAll();
            var entities = Mapper.Map<List<T>>(blEntities);
            return entities;
        }

        public T Update<T, S>(T entity)
        {
            var service = GetService<S>();
            var blEntity = Mapper.Map<S>(entity);
            var updatedBlEntity = service.Update(blEntity);
            var updatedEntity = Mapper.Map<T>(updatedBlEntity);
            return updatedEntity;
        }

        #endregion BaseOperations

        private IService<T> GetService<T>()
        {
            if (typeof(T) == typeof(User))
            {
                return UserService as IService<T>;
            }
            else if (typeof(T) == typeof(Auction))
            {
                return AuctionService as IService<T>;
            }
            else if (typeof(T) == typeof(Offer))
            {
                return OfferService as IService<T>;
            }
            else if (typeof(T) == typeof(Comment))
            {
                return CommentService as IService<T>;
            }
            else if (typeof(T) == typeof(Category))
            {
                return CategoryService as IService<T>;
            }
            else
            {
                throw new Exception("Unknown service type.");
            }
        }
    }
}
