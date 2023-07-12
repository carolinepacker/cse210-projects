using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {

    }

    public Customer (string name, string street, string city, string state, string country) 
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }

    public string Name 
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address
    {
        get { return _address; }
    }

    public bool IsCustomerUSA ()
    {
        if (_address.IsUSA())
        {
            return true;
        } 
        else
        {
            return false;
        }
    }
}