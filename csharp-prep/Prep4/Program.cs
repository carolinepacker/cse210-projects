using System;

class Program
{
    static void Main(string[] args)
    {
        // Adding to list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int addNumber = -1;
        List<int> numbers =  new List<int>();

        while(addNumber != 0)
        {
            Console.Write("Enter number: ");
            addNumber = int.Parse(Console.ReadLine());

            numbers.Add(addNumber);
        }


        // Calculations
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

    }
}