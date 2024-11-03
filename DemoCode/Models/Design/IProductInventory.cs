namespace DemoCode.Models.Design
{
    // Interface for inventory operations like adding, removing, and finding products
    public interface IProductInventory
    {
        void AddProduct(Product product);
        void RemoveProduct(int id);
        Product FindProductById(int id);
        List<Product> GetAllProducts();
    }
}