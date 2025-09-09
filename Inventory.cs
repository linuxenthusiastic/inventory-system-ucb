using System;
using System.Collections.Generic;

namespace inventory_system;

class Inventory
{
    private string Name;
    private List<Product> Products;

    public Inventory(string name)
    {
        Name = name;
        Products = new List<Product>();
    }

    public bool AddProduct(Product product)
    {
        Products.Add(product);
        return true;
    }

    public bool RemoveProduct(Product product)
    {
        Products.Remove(product);
        return true;
    }

    public bool FindProduct(string name)
    {
        foreach (Product product in Products)
        {
            if (product.GetName == name)
            {
                return true;
            }
        }
        return false;
    }

    public double CalculatePriceTotalInventory()
    {
        double total = 0;
        foreach (Product product in Products)
        {
            total += product.GetPrice;
        }
        return total;
    }

    public int CheckStock(string name)
    {
        foreach (Product product in Products)
        {
            if (product.GetName == name)
            {
                return (int)product.GetQty;
            }
        }
        return 0;
    }

    public bool UpdateStock(string name, int qty)
    {
        foreach (Product product in Products)
        {
            if (product.GetName == name)
            {
                product.UpdateQty(qty);
                return true;
            }
        }
        return false;
    }

    public bool DisplayInventoryByCategory(string category)
    {
        foreach (Product product in Products)
        {
            if (product.GetCategory == category)
            {
                Console.WriteLine(product.GetName);
            }
        }
        return true;
    }

    public bool DisplayFullInventory()
    {
        foreach (Product product in Products)
        {
            Console.WriteLine(product.GetName);
        }
        return true;
    }

    public DateTime ExpirationDate(string name)
    {
        foreach (Product product in Products)
        {
            if (product.GetName == name)
            {
                return product.GetExpiryDate;
            }
        }
        return DateTime.Now;
    }

    public DateTime WarrantyDate(string name)
    {
        foreach (Product product in Products)
        {
            if (product.GetName == name)
            {
                return product.GetWarrantyDate;
            }
        }
        return DateTime.Now;
    }

    public bool Fragile(string name)
    {
        foreach (Product product in Products)
        {
            if (product.GetName == name)
            {
                return product.GetFragile;
            }
        }
        return false;
    }

    public double Weight(string name)
    {
        foreach (Product product in Products)
        {
            if (product.GetName == name)
            {
                return product.GetWeight;
            }
        }
        return 0;
    }

    public double SizeElectronic(string name)
    {
        foreach (Product product in Products)
        {
            if (product.GetName == name)
            {
                return product.GetSize;
            }
        }
        return 0;
    }

    public double SizeClothes(string name)
    {
        foreach (Product product in Products)
        {
            if (product.GetName == name)
            {
                return product.GetSize;
            }
        }
        return 0;
    }

    public bool DiscountPerecederos(string name)
    {
        foreach (Perecederos product in Products)
        {   
            if (product.GetName == name)
            {
                if(product.GetExpiryDate < DateTime.Now)
                {
                    product.UpdateQty((int)product.GetQty - 1);
                    return true;
                }
            }
        }
        return false;
    }
}
