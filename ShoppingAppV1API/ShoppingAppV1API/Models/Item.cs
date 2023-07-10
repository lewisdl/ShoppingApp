using ShoppingAppV1API.Models.Interfaces;

namespace ShoppingAppV1API.Models
{
    public class Item : IItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float BundlePrice { get; set; }
    }
}
