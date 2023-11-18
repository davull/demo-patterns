namespace DependencyInversionPrinciple;

public static class OrderProcessor
{
    public static void Process(IOrder order)
    {
        var total = order.CalculateTotal();
        var shippingFee = order.CalculateShippingFee();
        var discount = order.GetDiscount();

        Print(total, shippingFee, discount);
    }

    public static void Process2(
        Func<decimal> calculateTotal,
        Func<decimal> calculateShippingFee,
        Func<decimal> getDiscount)
    {
        var total = calculateTotal();
        var shippingFee = calculateShippingFee();
        var discount = getDiscount();

        Print(total, shippingFee, discount);
    }

    private static void Print(decimal total, decimal shippingFee, decimal discount)
    {
        var grandTotal = total + shippingFee - discount;

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Total:       {total} EUR");
        Console.WriteLine($"Shipping:    {shippingFee} EUR");
        Console.WriteLine($"Discount:    {discount} EUR");
        Console.WriteLine($"Grand total: {grandTotal} EUR");
        Console.WriteLine();
    }
}