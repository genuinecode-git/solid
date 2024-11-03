namespace DemoCode.Models.Design;

// Handles sales operations such as selling products
public class SalesManager
{
    private Inventory inventory;

    public SalesManager(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void SellProduct(int productId, int quantity)
    {
        Product product = inventory.FindProductById(productId);
        if (product != null && product.Stock >= quantity)
        {
            product.Stock -= quantity;
            Console.WriteLine($"Sold {quantity} units of {product.Name}.");
            Console.WriteLine($"Total Sale: ${product.Price * quantity}\n");
        }
        else
        {
            Console.WriteLine("Product not found or insufficient stock.");
        }
    }
}