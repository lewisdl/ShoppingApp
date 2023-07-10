using ShoppingAppV1API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingAppV1API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly Cart _myCart;
        private readonly Store _myStore;

        //HTTPGETS
        [HttpGet("GetAllItems")]
        public List<Item> GetAllItems()
        {
            return _myStore.GetAllItems().Values.ToList(); //TODO: NullException Here "Object reference not set to an instance"
        }

        [HttpGet("GetCartItems")]
        public List<Item> GetCartItems()
        {
            return _myCart.GetAllItems(); //TODO: NullException Here "Object reference not set to an instance"
        }

        [HttpGet("GetTotal")] //Not Implemented
        public int GetTotal()
        {
            return 0;
        }

        
        //HTTPPOSTS
        [HttpPost("AddItemsToCart")]
        public void AddItemsToCart(Item MyItem)
        {
            _myCart.AddItemToCart(MyItem); //TODO: NullException Here "Object reference not set to an instance"
            return;
        }

        [HttpPost("ProcessPayment")] //Not Implemented
        public int ProcessPayment()
        {
            return 0;
        }

        //HTTPPUTS

        //HTTPDELETES


    }
}
