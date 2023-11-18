namespace DependencyInversionPrinciple;

public class VipCustomerOrder : IOrder
{
    private readonly decimal _total;

    public VipCustomerOrder(decimal total)
    {
        _total = total;
    }

    public decimal CalculateTotal() => _total;

    public decimal CalculateShippingFee() => _total > 100 ? 0 : 4.95m;

    public decimal GetDiscount()
    {
        return _total switch
        {
            > 100 => _total * 0.1m,
            > 50 => _total * 0.05m,
            _ => 0
        };
    }
}