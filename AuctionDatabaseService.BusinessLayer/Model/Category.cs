using System.Collections.Generic;

namespace AuctionDatabaseService.BusinessLayer.Model
{
    public class Category
    {
        public Category()
        {
            Items = new List<Item>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
