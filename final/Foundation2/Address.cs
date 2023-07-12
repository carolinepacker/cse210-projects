using System;

public class Address 
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    
    public Address (string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string Street 
    {
        get { return _street; }
        set { _street = value; }
    }

    public string City 
    {
        get { return _city; }
        set { _city = value; }
    }

    public string State 
    {
        get { return _state; }
        set { _state = value; }
    } 

    public string Country 
    {
        get { return _country; }
        set { _country = value; }
    }

    public bool IsUSA ()
    {
        if (_country == "USA" || _country == "United States" || _country == "United States of America") 
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public string DisplayAddress () 
    {
        return $"{_street} \n{_city}, {_state} \n{_country}";
    }
}