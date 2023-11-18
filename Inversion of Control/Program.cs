namespace InversionOfControl;

public static class Program
{
    // https://martinfowler.com/bliki/InversionOfControl.html

    public static void Main()
    {
        var driver = new Driver { GetName = GetPeterParker };
        driver.OnPrint += PrintToConsole;

        driver.Run();
    }

    private static string GetPeterParker()
    {
        return "Peter Parker";
    }

    private static void PrintToConsole(object? sender, string message)
    {
        Console.WriteLine($"{DateTime.Now:t} {message}");
    }
}