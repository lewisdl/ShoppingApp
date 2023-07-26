using ShoppingAppV1API.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ShoppingAppV1API.Models
{
    public class Cart
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinItems { get; set; }
        public float MinItemsFee { get; set; }

       
    }
}
