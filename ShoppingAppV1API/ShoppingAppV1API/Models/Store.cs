

namespace ShoppingAppV1API.Models
{
    public class Store
    {
        //LIST OF DATA STRUCTURES USED OVERALL
        // * List       - List that holds the items inside of each cart
        // * SortedList - SortedList for all of the items inside of the store. Sorted by item type
        // * Queue      - FIFO that holds all of the shopping carts
        SortedList<string,Item> Items = new SortedList<string, Item>();
        Queue<Cart> cartQueue = new Queue<Cart>(); //Queue of carts



        public SortedList<string,Item> GetAllItems() { return  Items; }
    }
}
