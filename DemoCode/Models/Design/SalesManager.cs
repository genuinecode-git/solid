namespace DemoCode.Models.Design
{
    // Handles sales operations such as selling products
    public class SalesManager : ISales
    {
        private IProductInventory _inventory;

        public SalesManager(IProductInventory inventory)
        {
            _inventory = inventory;
        }

        public void SellProduct(int productId, int quantity, IDiscount discountStrategy)
        {
            Product product = _inventory.FindProductById(productId);
            if (product != null && product.Stock >= quantity)
            {
                product.Stock -= quantity;
                decimal totalAmount = product.Price * quantity;

                if (discountStrategy != null)
                {
                    totalAmount = discountStrategy.ApplyDiscount(totalAmount);
                }

                Console.WriteLine($"Sold {quantity} units of {product.Name}.");
                Console.WriteLine($"Total Sale after Discount: ${totalAmount}\n");
            }
            else
            {
                Console.WriteLine("Product not found or insufficient stock.");
            }
        }
    }
}