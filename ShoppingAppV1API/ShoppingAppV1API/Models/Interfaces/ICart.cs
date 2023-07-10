namespace ShoppingAppV1API.Models.Interfaces
{
    public interface ICart
    {
        public string Id { get; set; } //Id for carts have to be in string
        public int MinItems { get; set; }
        public float MinItemsFee { get; set; }
        public void AddItemToCart(Item item);
        public void RemoveItemFromCart(Item item);
        public Item GetItem(string id); //This can return null
        public Item GetItemAt(int index);
        public List<Item> GetAllItems();
    }
}
