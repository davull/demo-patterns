namespace DependencyInjection;

public class OrderProcessor
{
    private readonly OrderService _orderService;
    private readonly PrintService _printService;

    public OrderProcessor(OrderService orderService, PrintService printService)
    {
        _orderService = orderService;
        _printService = printService;
    }

    public void ProcessOrder(string orderNumber, string shippingMethod)
    {
        var shippingFee = _orderService.GetShippingFee(shippingMethod);

        _printService.PrintShippingLabel(
            shippingMethod: shippingMethod,
            shippingFee: shippingFee,
            orderNumber: orderNumber);
    }
}