namespace ShoppingAppV1API.Models.Interfaces
{
    public interface IPayment
    {
        string Name { get; set; }
        string CardNumber { get; set; }
        string ExpireDate { get; set; }
        ushort CCV { get; set; }
        float ItemTotal { get; set; }
        float BundleTotal { get; set; }
        float TaxTotal { get; set; }

    }
}
