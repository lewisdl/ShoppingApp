using Microsoft.EntityFrameworkCore;
using ShoppingAppV1API.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ShoppingAppV1API.Models
{
    public class CartContext : DbContext
    {
        public CartContext(DbContextOptions<CartContext> options) : base(options)
        {

        }
        public DbSet<Cart> Carts { get; set; } = null;
    }
}
