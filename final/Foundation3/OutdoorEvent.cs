using System;

public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string type, string description, string date, string time, string street, string city, string state, string country, string weather) : base(title, type, description, date, time, street, city, state, country)
    {
        _weather = weather;
    }

    public void OutdoorFull()
    {
        Console.WriteLine($"Weather Forecast: {_weather}");
        Console.WriteLine("");
    }
}