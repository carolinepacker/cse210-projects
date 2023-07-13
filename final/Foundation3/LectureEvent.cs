using System;

public class LectureEvent : Event 
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string type, string description, string date, string time, string street, string city, string state, string country, string speaker, int capactiy) : base(title, type, description, date, time, street, city, state, country)
    {
        _speaker = speaker;
        _capacity = capactiy;
    }

    public void LectureFull()
    {
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity.ToString()}");
        Console.WriteLine("");
    }
}