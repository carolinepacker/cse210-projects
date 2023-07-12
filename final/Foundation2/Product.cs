using System;

public class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;

    public Product (string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string Name 
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Id 
    {
        get { return _id; }
        set { _id = value; }
    }

    public int Price 
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity 
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public int CalculatePrice ()
    {
        return _price * _quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{_name} ({_id.ToString()}): ${_price.ToString()} | # of items: {_quantity.ToString()}");
    }
}