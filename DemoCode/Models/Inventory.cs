namespace DemoCode.Models
{
    // Manages inventory operations like adding, removing, and displaying products
    public class Inventory : IProductInventory
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
            Console.WriteLine("Product added successfully.");
        }

        public void RemoveProduct(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
                Console.WriteLine("Product removed successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public Product FindProductById(int id)
        {
            return _products.Find(p => p.Id == id);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}