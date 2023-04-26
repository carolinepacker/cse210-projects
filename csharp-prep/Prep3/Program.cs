using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        // string magicNumStr = Console.ReadLine();
        // int magicNum = int.Parse(magicNumStr);
        
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNum) 
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
    
    }
}