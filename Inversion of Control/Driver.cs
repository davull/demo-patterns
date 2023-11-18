namespace InversionOfControl;

public class Driver
{
    public event EventHandler<string>? OnPrint;

    public Func<string>? GetName = null;

    public void Run()
    {
        OnPrint?.Invoke(this, "Hello, welcome to the show!");
        var name = GetName?.Invoke() ?? "Anonymous";
        OnPrint?.Invoke(this, $"Hello, {name}!");
    }
}