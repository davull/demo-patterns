namespace DecoratorPattern;

public class Program
{
    public static void Main()
    {
        var orderService = new DiscountOrderService(
            new LoggingOrderService(
                new OrderService()));

        orderService.ProcessOrder(
            orderId: "ORD-0815",
            shippingMethod: "UPS",
            total: 90.95m);
    }
}