namespace DemoCode.ShopMain
{
    // Runs the main menu and coordinates between Inventory, Sales, and Customer Service
    public class Shop
    {
        private IProductInventory _inventory = new Inventory();
        private ISales _salesManager;
        private CustomerService _customerService;

        public Shop()
        {
            _salesManager = new SalesManager(_inventory);
            _customerService = new CustomerService(_inventory);
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Hardware Shop Management ===");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Display Products");
                Console.WriteLine("4. Sell Product with Discount");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        RemoveProduct();
                        break;
                    case "3":
                        _customerService.ShowAvailableProducts();
                        break;
                    case "4":
                        SellProductWithDiscount();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private void AddProduct()
        {
            Console.Write("Enter product ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter stock quantity: ");
            int stock = int.Parse(Console.ReadLine());

            Product product = new Product(id, name, price, stock);
            _inventory.AddProduct(product);
        }
 private void RemoveProduct()
        {
            Console.Write("Enter product ID to remove: ");
            int id = int.Parse(Console.ReadLine());
            _inventory.RemoveProduct(id);
        }
        private void SellProductWithDiscount()
        {
            Console.Write("Enter product ID to sell: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter quantity to sell: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect Discount Type:");
            Console.WriteLine("1. Bulk Discount (10% off for bulk)");
            Console.WriteLine("2. No Discount");
            Console.Write("Select an option: ");

            IDiscount discountStrategy = null;
            switch (Console.ReadLine())
            {
                case "1":
                    discountStrategy = new BulkDiscount(10, 10);
                    break;
                case "2":
                    discountStrategy = new NoDiscount();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            _salesManager.SellProduct(id, quantity, discountStrategy);
        }
    }
}