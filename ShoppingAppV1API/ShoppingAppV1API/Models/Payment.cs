using ShoppingAppV1API.Models.Interfaces;

namespace ShoppingAppV1API.Models
{
    public class Payment : IPayment
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string ExpireDate { get; set; }
        public ushort CCV { get; set; }
        public float ItemTotal { get; set; }
        public float BundleTotal { get; set; }
        public float TaxTotal { get; set; }
    }
}
