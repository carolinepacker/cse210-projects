using System;

public class Event
{
    private string _title;
    private string _type;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event (string title, string type, string description, string date, string time, string street, string city, string state, string country)
    {
        _title = title;
        _type = type;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(street, city, state, country);
    }


    public void DisplayStandard()
    {
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"{_date} @ {_time}");
        Console.WriteLine($"{_address.DisplayAddress()}");
        Console.WriteLine($"----- Event Type: {_type} -----");
    }

    public void DisplayShortDesc()
    {
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine("");
    }

}