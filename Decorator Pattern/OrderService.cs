namespace DecoratorPattern;

public class OrderService : IOrderService
{
    public void ProcessOrder(string orderId, string shippingMethod, decimal total)
    {
        Console.WriteLine($"{nameof(OrderService),-30}: Processing order " +
                          $"{orderId} using {shippingMethod}, total: {total}");
    }
}