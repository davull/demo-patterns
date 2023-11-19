namespace DependencyInjection;

public class Program
{
    public static void Main()
    {
        var orderService = new OrderService();
        var printService = new PrintService();

        var processor = new OrderProcessor(orderService, printService);
        processor.ProcessOrder("ORD-001", "UPS");
    }
}