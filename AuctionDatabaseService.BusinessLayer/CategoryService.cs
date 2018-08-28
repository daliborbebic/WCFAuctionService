using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Contracts;
using AuctionDatabaseService.BusinessLayer.Model;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Repositories;
using AutoMapper;
using DbCategory = AuctionDatabaseService.Facades.Database.Model.Category;

namespace AuctionDatabaseService.BusinessLayer
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Add(Category category)
        {
            var dbCategory = Mapper.Map<DbCategory>(category);
            var createdDbCategory = _categoryRepository.Add(dbCategory);
            var createdCategory = Mapper.Map<Category>(createdDbCategory);
            return createdCategory;
        }

        public void AddRange(IEnumerable<Category> categories)
        {

            IEnumerable<DbCategory> dbCategories = Mapper.Map<IEnumerable<DbCategory>>(categories);
            _categoryRepository.AddRange(dbCategories);
        }

        public IEnumerable<Category> GetAll()
        {
            var dbCategories = _categoryRepository.GetAll();
            var categories = Mapper.Map<IEnumerable<Category>>(dbCategories);
            return categories;
        }

        public Category GetById(int categoryId)
        {
            var dbCategory = _categoryRepository.GetById(categoryId);
            var categories = Mapper.Map<Category>(dbCategory);
            return categories;
        }

        public void Remove(Category category)
        {
            var dbCategory = Mapper.Map<DbCategory>(category);
            _categoryRepository.Remove(dbCategory);
        }

        public void RemoveRange(IEnumerable<Category> categories)
        {
            var dbCategories = Mapper.Map<IEnumerable<DbCategory>>(categories);
            _categoryRepository.RemoveRange(dbCategories);
        }

        public Category Update(Category category)
        {
            var dbCategory = Mapper.Map<DbCategory>(category);
            var updatedDbCategory = _categoryRepository.Update(dbCategory);
            var updatedCategory = Mapper.Map<Category>(updatedDbCategory);
            return updatedCategory;
        }
    }
}
