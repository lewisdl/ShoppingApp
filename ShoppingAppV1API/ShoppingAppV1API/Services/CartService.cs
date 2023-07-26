using ShoppingAppV1API.Models;

namespace ShoppingAppV1API.Services
{
    public class CartService
    {
        private List<Item> _items { get; set; }
        public bool AddItemToCart(Item item, int quantity)
        {
            if (item == null)
            {
                return false;
            }
            for (var i = 0; i < quantity; i++)
            {
                _items.Add(item);   
            }
            return true;
        }

        public List<Item> GetAllItems()
        {
            return _items;
        }

        public Item GetItem(int id) //This can return null. Make sure to preform a null-check
        {
            //Use LINQ here
            var item = _items.Where(i => i.Id == id).FirstOrDefault();
            

            //Previously how it was handled
            /*foreach (var item in _items)
            {
                //Previous way it was handled
                if (item.Id == id) 
                {
                    return item;
                }
            }*/
            return item; //Remember that item could be null
        }

        public Item GetItemAt(int index)
        {
            return _items[index];
        }

        public bool RemoveItemFromCart(int id) //Using ID instead of an Item
        {
            //Use LINQ here
            var item = _items.Where(i => i.Id == id).FirstOrDefault();
            
            if (item != null)
            {
                _items.Remove(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
