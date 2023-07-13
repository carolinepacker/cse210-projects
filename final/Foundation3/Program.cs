using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent lecture1 = new LectureEvent("TEDx: Procrastination", "Lecture", "TEDx talk about the new generation of procrastination.", "June 11, 2024", "3:30 PM", "443 University Ave", "Provo", "Utah", "United States", "Meredith Grey M.D.", 330);
        ReceptionEvent reception1 = new ReceptionEvent("Nielson Wedding", "Reception", "Wedding Reception for Garrett and Caroline Nielson", "March 3, 2023", "6:30 PM", "25 South Main Street", "Brigham City", "Utah", "United States", "carolinenielson@hotmail.com");
        OutdoorEvent outdoor1 = new OutdoorEvent("Farmers Market", "Outdoor", "Weekly Farmers Market for Ogden residents", "July 15, 2023", "10:00 AM", "25th Street", "Ogden", "Utah", "United States", "Partly Cloudy, 87 degrees");

        // lecture displays
        Console.WriteLine("~~~~~~~ LECTURE ~~~~~~~~~~~~~~~~");
        lecture1.DisplayStandard();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        lecture1.DisplayStandard();
        lecture1.LectureFull();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        lecture1.DisplayShortDesc();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~ RECEPTION ~~~~~~~~~~~~~");
        reception1.DisplayStandard();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        reception1.DisplayStandard();
        reception1.ReceptionFull();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        reception1.DisplayShortDesc();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~ OUTDOOR ~~~~~~~~~~~~~~~");
        outdoor1.DisplayStandard();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        outdoor1.DisplayStandard();
        outdoor1.OutdoorFull();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        outdoor1.DisplayShortDesc();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}