namespace DemoCode.ShopMain.Discounts
{

    // Interface for different discount strategies
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
}