namespace DecoratorPattern;

public class DiscountOrderService : IOrderService
{
    private readonly IOrderService _innerOrderService;

    public DiscountOrderService(IOrderService innerOrderService)
    {
        _innerOrderService = innerOrderService;
    }

    public void ProcessOrder(string orderId, string shippingMethod, decimal total)
    {
        Console.WriteLine($"{nameof(DiscountOrderService),-30}: Apply 10% discount");

        total *= 0.9m;
        _innerOrderService.ProcessOrder(orderId, shippingMethod, total);
    }
}