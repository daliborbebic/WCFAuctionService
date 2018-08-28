using System.Collections.Generic;
using AuctionDatabaseService.BusinessLayer.Contracts;
using AuctionDatabaseService.BusinessLayer.Model;
using AuctionDatabaseService.Facades.Database.Contracts;
using AuctionDatabaseService.Facades.Database.Repositories;
using AutoMapper;
using DbItem = AuctionDatabaseService.Facades.Database.Model.Item;

namespace AuctionDatabaseService.BusinessLayer
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService()
        {
            _itemRepository = new ItemRepository();
        }

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public Item Add(Item item)
        {
            var dbItem = Mapper.Map<DbItem>(item);
            var createdDbItem = _itemRepository.Add(dbItem);
            var createdItem = Mapper.Map<Item>(createdDbItem);
            return createdItem;
        }

        public void AddRange(IEnumerable<Item> items)
        {

            IEnumerable<DbItem> dbItems = Mapper.Map<IEnumerable<DbItem>>(items);
            _itemRepository.AddRange(dbItems);
        }

        public IEnumerable<Item> GetAll()
        {
            var dbItems = _itemRepository.GetAll();
            var items = Mapper.Map<IEnumerable<Item>>(dbItems);
            return items;
        }

        public Item GetById(int itemId)
        {
            var dbItem = _itemRepository.GetById(itemId);
            var items = Mapper.Map<Item>(dbItem);
            return items;
        }

        public void Remove(Item item)
        {
            var dbItem = Mapper.Map<DbItem>(item);
            _itemRepository.Remove(dbItem);
        }

        public void RemoveRange(IEnumerable<Item> items)
        {
            var dbItems = Mapper.Map<IEnumerable<DbItem>>(items);
            _itemRepository.RemoveRange(dbItems);
        }

        public Item Update(Item item)
        {
            var dbItem = Mapper.Map<DbItem>(item);
            var updatedDbItem = _itemRepository.Update(dbItem);
            var updatedItem = Mapper.Map<Item>(updatedDbItem);
            return updatedItem;
        }
    }
}
