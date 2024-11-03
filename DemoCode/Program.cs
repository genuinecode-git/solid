namespace DemoCode;

class Program
{
    static void Main(string[] args)
    {
        // Setup dependencies
        IProductInventory inventory = new Inventory();
        ISales salesManager = new SalesManager(inventory);
        CustomerService customerService = new CustomerService(inventory);

        // Pass dependencies to Shop (Dependency Injection)
        Shop shop = new Shop(inventory, salesManager, customerService);
        shop.Run();
    }
}

