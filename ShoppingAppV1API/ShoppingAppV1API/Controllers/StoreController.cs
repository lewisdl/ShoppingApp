using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using ShoppingAppV1API.Models;
using ShoppingAppV1API.Services;


namespace ShoppingAppV1API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly CartService _cartService;
        


        private readonly ILogger<StoreController> _logger;
        private ItemContext _itemContext;
        private CartContext _cartContext;

        public StoreController(ILogger<StoreController> logger, ItemContext itemContext,
            CartContext cartContext)
        {
            _logger = logger;
            _itemContext = itemContext;
            _cartContext = cartContext;
        }

        //GETS
        [HttpGet("GetAllItems")]
        public List<Models.Item> GetAllItems() //Getting All Items
        {
            return _itemContext.Items.ToList();
        }

        //POSTS
        [HttpPost("CreateNewCart")]
        public int CreateNewCart(string name) //Create cart, return cart Id
        {
            var cart = new Cart();
            cart.Name = name;
            _cartContext.Carts.Add(cart);
            _cartContext.SaveChanges();
            return cart.Id;
        }
        
        //POSTS
        [HttpPost("AddItemsToCart")]
        public async Task<ActionResult<ServiceResponse>> AddItemToCart(int cartId, Models.Item item, int quantity) //Adds item to cart. Returns Success/Fail
        {
            var cart = _cartContext.Carts.Where(c => c.Id == cartId).FirstOrDefault();
            var result = _cartService.AddItemToCart(item, quantity);
            if (result && cart != null) //If the item was added successfully
            {
                _cartContext.SaveChanges();
                return Ok("Item was added successfully to cart");
            }
            else
            {
                return BadRequest("Item wasn't added successfully to cart");
            }
        }
    }
}