using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using ShoppingAppV1API.Models;
using ShoppingAppV1API.Services;

namespace ShoppingAppV1API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        //private readonly CartService _myCart;
        /*private readonly Store _myStore; //Make a new instance for _myStore and _myCart
        */



        private readonly ILogger<CartController> _logger;
        private CartContext _cartContext;
        private ItemContext _itemContext;

        public CartController(ILogger<CartController> logger, CartContext cartContext,
            ItemContext itemContext)
        {
            _logger = logger;
            _cartContext = cartContext;
            _itemContext = itemContext;
        }

        //GETS
        [HttpGet("GetCart")]
        public Cart GetCartItems(int cartId) //Getting All Items In Cart
        {

            return _cartContext.Carts.Where(c => c.Id == cartId).FirstOrDefault();
        }

        //DELETES
        [HttpDelete("RemoveItem")]
        public Cart RemoveItem(int cartId, int itemId) //Getting All Items In Cart
        {
            var cart = _cartContext.Carts.Where(c => c.Id == cartId).FirstOrDefault();
            var item = _itemContext.Items.Where(i => i.Id == itemId).FirstOrDefault();

            return cart;
        }

    }
}