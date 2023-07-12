using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order (string name, string street, string city, string state, string country)
    {
        _customer = new Customer(name, street, city, state, country);
    }

    public void AddProduct (string name, int id, int price, int quantity)
    {
        Product newProduct = new Product(name, id, price, quantity);
        _products.Add(newProduct);
    }

    public int TotalCost()
    {
        int totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculatePrice();
        }

        if (_customer.IsCustomerUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public void DisplayPacking()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("----- Packing Label -----");
        Console.WriteLine("-------------------------");
        foreach(Product product in _products)
        {
            product.DisplayProduct();
        }
        Console.WriteLine($"Total: ${TotalCost().ToString()}");
    }

    public void DisplayShipping() 
    {
        Console.WriteLine("----- Shipping Label -----");
        Console.WriteLine(_customer.Name);
        Console.WriteLine(_customer.Address.DisplayAddress());
    }
}