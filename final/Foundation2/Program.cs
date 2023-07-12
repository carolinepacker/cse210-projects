using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Order order1 = new Order("Meredith Grey", "123 Ocean View Street", "Seattle", "WA", "USA");
        order1.AddProduct("Closet Shelf", 2234980, 56, 2);
        order1.AddProduct("100 Hangers", 4423357, 10, 3);
        order1.AddProduct("Shoe Rack", 44275544, 80, 1);
        // Second Order
        Order order2 = new Order("Derek Shepherd", "100 West 200 South", "Salt Lake City", "UT", "United States");
        order2.AddProduct("Brother Printer", 3302877, 176, 1);
        order2.AddProduct("White Printer Paper: 1 Ream", 8937569, 6, 2);
        // Third Order
        Order order3 = new Order("Matilda Djerf", "1432 Bjorn Avenue", "Stockholm", "N/A", "Sweden");
        order3.AddProduct("Fluffy Robe", 3346664, 78, 1);
        order3.AddProduct("Ballerina Flats", 9473688, 54, 1);

        // Display All Orders
        order1.DisplayShipping();
        order1.DisplayPacking();
        Console.WriteLine("");
        order2.DisplayShipping();
        order2.DisplayPacking();
        Console.WriteLine("");
        order3.DisplayShipping();
        order3.DisplayPacking();
        Console.WriteLine("");
    }
}