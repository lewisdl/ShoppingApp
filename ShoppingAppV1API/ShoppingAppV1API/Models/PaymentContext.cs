using Microsoft.EntityFrameworkCore;
using ShoppingAppV1API.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ShoppingAppV1API.Models
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {

        }
        public DbSet<Payment> Payments { get; set; } = null;
    }
}
