using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using ShoppingAppV1API.Models;
using ShoppingAppV1API.Services;

namespace ShoppingAppV1API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        //private readonly CartService _myCart;
        /*private readonly Store _myStore; //Make a new instance for _myStore and _myCart
        */



        private readonly ILogger<PaymentController> _logger;
        private CartContext _cartContext;
        private ItemContext _itemContext;

        public PaymentController(ILogger<PaymentController> logger, CartContext cartContext,
            ItemContext itemContext)
        {
            _logger = logger;
            _cartContext = cartContext;
            _itemContext = itemContext;
        }

        //GETS
        [HttpGet("GetTotals")]
        public IList<T> GetTotals<T>(int cartId) //Getting All Items In Cart
        {

            return (IList<T>)_cartContext.Carts
                .Where(c => c.Id == cartId)
                .Select(c => new { });
            //Has to return ItemTotal, BundleTotal, TaxTotal 
        }

        //PUTS
        [HttpPut("ProcessPayment")]
        public async Task<ActionResult<ServiceResponse>> ProcessPayment(int cartId, string cardNumber, string exp,
            string cardHolderName, string cvc) //Getting All Items In Cart
        {
            //var cart = _cartContext.Carts.Where(c => c.Id == cartId).FirstOrDefault();
            //var item = _itemContext.Items.Where(i => i.Id == itemId).FirstOrDefault();

            return Ok();
        }

    }
}