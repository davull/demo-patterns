namespace DecoratorPattern;

public class LoggingOrderService : IOrderService
{
    private readonly IOrderService _innOrderService;

    public LoggingOrderService(IOrderService innOrderService)
    {
        _innOrderService = innOrderService;
    }

    public void ProcessOrder(string orderId, string shippingMethod, decimal total)
    {
        Console.WriteLine($"{nameof(LoggingOrderService),-22} [{DateTime.Now:t}]: " +
                          $"Start orderId: {orderId}");

        _innOrderService.ProcessOrder(orderId, shippingMethod, total);

        Console.WriteLine($"{nameof(LoggingOrderService), -22} [{DateTime.Now:t}]: End");
    }
}