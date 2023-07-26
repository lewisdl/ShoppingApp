using ShoppingAppV1API.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ShoppingAppV1API.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float BundlePrice { get; set; }
    }
}
