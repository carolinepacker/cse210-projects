using System;

public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string type, string description, string date, string time, string street, string city, string state, string country, string email) : base(title, type, description, date, time, street, city, state, country)
    {
        _email = email;
    }

    public void ReceptionFull()
    {
        Console.WriteLine($"RSVP: {_email}");
        Console.WriteLine("");
    }
}