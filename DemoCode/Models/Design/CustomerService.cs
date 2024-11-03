namespace DemoCode.Models.Design;

public class CustomerService
{
    private Inventory _inventory;

    public CustomerService(Inventory inventory)
    {
        this._inventory = inventory;
    }

    public void ShowAvailableProducts()
    {
        Console.WriteLine("\nAvailable Products:");
        _inventory.DisplayProducts();
    }
}