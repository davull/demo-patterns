namespace DependencyInjection;

public class PrintService
{
    public void PrintShippingLabel(
        string shippingMethod,
        decimal shippingFee,
        string orderNumber)
    {
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Order Number:    {orderNumber}");
        Console.WriteLine($"Shipping Method: {shippingMethod}");
        Console.WriteLine($"Shipping Fee:    {shippingFee}");
        Console.WriteLine();
    }
}