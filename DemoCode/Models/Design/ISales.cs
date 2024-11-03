namespace DemoCode.Models.Design{
    // Interface for sales operations
    public interface ISales
    {
        void SellProduct(int productId, int quantity, IDiscount discountStrategy);
    }
}