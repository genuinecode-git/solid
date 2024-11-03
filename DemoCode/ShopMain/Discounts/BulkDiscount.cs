namespace DemoCode.ShopMain.Discounts;

// Discount strategy that provides a discount for bulk purchases
public class BulkDiscount : IDiscount
{
    private int _minimumQuantity;
    private decimal _discountPercentage;

    public BulkDiscount(int minimumQuantity, decimal discountPercentage)
    {
        this._minimumQuantity = minimumQuantity;
        this._discountPercentage = discountPercentage;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        // Apply discount if the total purchase meets the bulk quantity threshold
        return _minimumQuantity >3 ? totalAmount - (totalAmount * _discountPercentage / 100) : totalAmount;
    }
}