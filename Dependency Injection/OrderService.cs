namespace DependencyInjection;

public class OrderService
{
    public decimal GetShippingFee(string shippingMethod)
    {
        return shippingMethod switch
        {
            "UPS" => 4.88m,
            "FedEx" => 7.99m,
            "USPS" => 5.55m,
            _ => throw new ArgumentException("Invalid shipping method")
        };
    }
}