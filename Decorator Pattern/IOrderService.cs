namespace DecoratorPattern;

public interface IOrderService
{
    void ProcessOrder(string orderId, string shippingMethod, decimal total);
}