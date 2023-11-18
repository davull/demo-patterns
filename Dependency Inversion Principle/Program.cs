namespace DependencyInversionPrinciple;

public static class Program
{
    public static void Main()
    {
        var order = new VipCustomerOrder(95);

        OrderProcessor.Process(order);

        OrderProcessor.Process2(
            order.CalculateTotal,
            order.CalculateShippingFee,
            order.GetDiscount);

        OrderProcessor.Process2(
            calculateTotal: () => 95m,
            calculateShippingFee: () => 4.88m,
            getDiscount: () => 5m);
    }
}