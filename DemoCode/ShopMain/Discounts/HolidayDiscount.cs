namespace DemoCode.ShopMain.Discounts;

public class HolidayDiscount : IDiscount
{
    private decimal holidayDiscountAmount;

    public HolidayDiscount(decimal holidayDiscountAmount)
    {
        this.holidayDiscountAmount = holidayDiscountAmount;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        // Apply flat holiday discount
        return totalAmount - holidayDiscountAmount;
    }
}