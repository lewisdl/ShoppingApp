namespace ShoppingAppV1API.Models.Interfaces
{
    public interface IItem
    {
        public string Id { get; set; } //Id for items has to be string
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float BundlePrice { get; set; }

    }
}
