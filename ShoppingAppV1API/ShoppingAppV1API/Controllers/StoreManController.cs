using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using ShoppingAppV1API.Models;
using ShoppingAppV1API.Services;

namespace ShoppingAppV1API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreManController : ControllerBase
    {
        //private readonly CartService _myCart;
        /*private readonly Store _myStore; //Make a new instance for _myStore and _myCart
        */



        private readonly ILogger<StoreManController> _logger;
        private CartContext _cartContext;
        private ItemContext _itemContext;

        public StoreManController(ILogger<StoreManController> logger, CartContext cartContext,
            ItemContext itemContext)
        {
            _logger = logger;
            _cartContext = cartContext;
            _itemContext = itemContext;
        }

        //PUTS
        [HttpPut("UpdateStock")]
        public async Task<ActionResult<ServiceResponse>> GetTotals(int itemId, 
            int quantity) //Getting All Items In Cart
        {

            return Ok();
            //Has to return ItemTotal, BundleTotal, TaxTotal 
        }

        [HttpPut("ChangePrice")]
        public async Task<ActionResult<ServiceResponse>> ProcessPayment(int itemId,
            int price) //Getting All Items In Cart
        {
            //var cart = _cartContext.Carts.Where(c => c.Id == cartId).FirstOrDefault();
            //var item = _itemContext.Items.Where(i => i.Id == itemId).FirstOrDefault();

            return Ok();
        }

        //POSTS
        [HttpPost("AddNewItem")]
        public async Task<ActionResult<ServiceResponse>> AddNewItem(Models.Item item) //Getting All Items In Cart
        {
            //var cart = _cartContext.Carts.Where(c => c.Id == cartId).FirstOrDefault();
            //var item = _itemContext.Items.Where(i => i.Id == itemId).FirstOrDefault();

            return Ok();
        }


    }
}