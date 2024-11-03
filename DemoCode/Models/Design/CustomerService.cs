namespace DemoCode.Models.Design
{
    public class CustomerService
    {
        private IProductInventory _inventory;

        public CustomerService(IProductInventory inventory)
        {
            _inventory = inventory;
        }

        public void ShowAvailableProducts()
        {
            Console.WriteLine("\nAvailable Products:");
            foreach (var product in _inventory.GetAllProducts())
            {
                product.DisplayInfo();
            }
        }
    }
}