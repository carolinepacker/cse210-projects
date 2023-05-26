using System;

// For my stretch activity I made a list of scriptures to memorize. The program picks a random one for the user.
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Scripture scripture1 = new Scripture("Proverbs", "3", "5", "6", "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Scripture scripture2 = new Scripture("John", "3", "16", "For God so loved the world, that he gave His only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture scritpure3 = new Scripture("D&C", "18", "10", "Remember the worth of souls is great in the sight of God.");
        Scripture scripture4 = new Scripture("D&C", "19", "23", "Learn of me, and listen to my words; walk in the meekness of my Spirit, and you shall have peace in me.");
        scriptures.Add(scripture1);
        scriptures.Add(scripture2);
        scriptures.Add(scritpure3);
        scriptures.Add(scripture4);

        Random random = new Random();
        int scriptureIndex = random.Next(scriptures.Count());
        Scripture currentScripture = scriptures[scriptureIndex];

        bool cont = true;
        while (cont == true)
        {
            Console.WriteLine(currentScripture.DisplayScripture());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            if (Console.ReadLine() == "")
            {
                if (currentScripture.GetEraseCount() < currentScripture.GetWords().Count())
                {
                    currentScripture.EraseWord();
                    currentScripture.EraseWord();
                    currentScripture.EraseWord();
                } else {
                    cont = false;
                }
                
            } else
            {
                cont = false;
            }
        }
    }
}