using System;

namespace inventory_system;

class Program 
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory("Inventory");

        inventory.AddProduct(new Perecederos("Milk", 10, 2.99, "Dairy", DateTime.Now.AddDays(7)));

        inventory.DiscountPerecederos("Milk");

        Console.WriteLine(inventory.ExpirationDate("Milk"));

        Console.WriteLine(inventory.CalculatePriceTotalInventory());

        Console.WriteLine(inventory.CheckStock("Milk"));

        Console.WriteLine(inventory.UpdateStock("Milk", 5));

        Console.WriteLine(inventory.DisplayFullInventory());

        Console.WriteLine(inventory.DisplayInventoryByCategory("Dairy"));
    }
}