using System.Collections.Generic;

namespace GroceryApp
{
    public class GroceryList
    {
        public int ListId { get; set; }
        public string Name { get; set; }
        public List<GroceryItem> Items { get; set; }

        public GroceryList()
        {
            Items = new List<GroceryItem>();
        }
    }
}
