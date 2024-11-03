namespace DemoCode.ShopMain.Discounts{

    // Discount strategy that provides no discount
    public class NoDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            // Return the original amount with no discount applied
            return totalAmount;
        }
    }
}