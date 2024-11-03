namespace DemoCode.Models {

    // Manages inventory operations like adding, removing, and displaying products
    public class Inventory
    {
        private List<Product> _products = [];

        public void AddProduct(Product product)
        {
            this._products.Add(product);
            Console.WriteLine("Product added successfully.");
        }

        public void RemoveProduct(int id)
        {
            var product = this._products.Find(p => p.Id == id);
            if (product != null)
            {
                this._products.Remove(product);
                Console.WriteLine("Product removed successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public Product FindProductById(int id)
        {
            return this._products.Find(p => p.Id == id);
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\nCurrent Inventory:");
            foreach (var product in this._products)
            {
                product.DisplayInfo();
            }
        }
    }
}