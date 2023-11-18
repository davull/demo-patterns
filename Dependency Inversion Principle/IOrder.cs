namespace DependencyInversionPrinciple;

public interface IOrder
{
    decimal CalculateTotal();

    decimal CalculateShippingFee();

    decimal GetDiscount();
}