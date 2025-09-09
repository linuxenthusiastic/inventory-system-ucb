using System;
using System.Collections.Generic;

namespace inventory_system;

class Product
{
    private string Name;
    private int Qty;
    private double Price;
    private string Category;

    public Product(string name, int qty, double price, string category)
    {
        Name = name;
        Qty = qty;
        Price = price;
        Category = category;
    }

    public string GetName
    {
        get {return Name;}
    }

    public double GetPrice
    {
        get {return Price;}
    }

    public int GetQty
    {
        get {return Qty;}
    }

    public string GetCategory
    {
        get {return Category;}
    }

    public bool UpdateQty(int qty)
    {
        Qty = qty;
        return true;
    }

    public virtual DateTime GetExpiryDate 
    { 
        get { return DateTime.MinValue; } 
    }
    
    public virtual DateTime GetWarrantyDate 
    { 
        get { return DateTime.MinValue; } 
    }
    
    public virtual bool GetFragile 
    { 
        get { return false; } 
    }
    
    public virtual double GetWeight 
    { 
        get { return 0; } 
    }
    
    public virtual double GetSize 
    { 
        get { return 0; } 
    }
}

class Perecederos:Product
{
    private DateTime ExpiryDate;

    public Perecederos(string name, int qty, double price, string category, DateTime expiryDate)
    :base(name, qty, price, category)
    {
        ExpiryDate = expiryDate;
    }

    public new DateTime GetExpiryDate
    {
        get {return ExpiryDate;}
    }
}

class Electronics:Product
{
    private DateTime WarrantyDate;
    private bool Fragile;
    private double Weight;
    private double Size;

    public Electronics(string name, int qty, double price, string category, DateTime warrantyDate, bool fragile, double weight, double size)
    :base(name, qty, price, category)
    {
        WarrantyDate = warrantyDate;
        Fragile = fragile;
        Weight = weight;
        Size = size;
    }

    public new DateTime GetWarrantyDate
    {
        get {return WarrantyDate;}
    }

    public new bool GetFragile
    {
        get {return Fragile;}
    }

    public new double GetWeight
    {
        get {return Weight;}
    }

    public new double GetSize
    {
        get {return Size;}
    }
}


class Clothes:Product
{
    private string Size;

    public Clothes(string name, int qty, double price, string category, string size)
    :base(name, qty, price, category)
    {
        Size = size;
    }

    public string GetSize
    {
        get {return Size;}
    }
}