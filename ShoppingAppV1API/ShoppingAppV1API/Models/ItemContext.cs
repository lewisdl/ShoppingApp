using Microsoft.EntityFrameworkCore;
using ShoppingAppV1API.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ShoppingAppV1API.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; } = null;
    }
}
