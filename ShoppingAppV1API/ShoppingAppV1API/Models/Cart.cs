using ShoppingAppV1API.Models.Interfaces;

namespace ShoppingAppV1API.Models
{
    public class Cart : ICart
    {

        private List<Item> Items;
        public Cart() 
        { 

        }

        public Cart(List<Item> items)
        {

        }
        public string Id { get; set; }
        public int MinItems { get; set; }
        public float MinItemsFee { get; set; }

        public void AddItemToCart(Item item)
        {
            Items.Add(item);
        }

        public List<Item> GetAllItems()
        {
            return Items;
        }

        public Item GetItem(string id) //This can return null. Make sure to preform a null-check
        {
            foreach (var item in Items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Item GetItemAt(int index)
        {
            return Items[index];
        }

        public void RemoveItemFromCart(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
