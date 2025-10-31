using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random(); // Create a random number generator

        List<Scripture> scriptures = new List<Scripture>(); // to hold multiple scriptures

        // 1. Proverbs 3:5-6
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        Scripture s1 = new Scripture(r1, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in  all thy ways acknowledge him, and he will direct thy paths.");
        scriptures.Add(s1);

        // 2. John 3:16
        Reference r2 = new Reference("John", 3, 16);
        Scripture s2 = new Scripture(r2, "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.");
        scriptures.Add(s2);

        // 3. Philippians 4:13
        Reference r3 = new Reference("Philippians", 4, 13);
        Scripture s3 = new Scripture(r3, "I can do all things through Christ which strengtheneth me.");
        scriptures.Add(s3);

        // 4. 2 Nephi 2:25 
        Reference r4 = new Reference("2 Nephi", 2, 25);
        Scripture s4 = new Scripture(r4, "Adam fell that men might be and men are that they might have joy.");
        scriptures.Add(s4);

        // Picks a random scripture from the list 
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        // 
        Console.Clear();
        Console.WriteLine("Today's scripture to memorize:");
        Console.WriteLine(scripture.GetRenderedText());
        Console.WriteLine();
        Console.WriteLine("Press Enter to begin hiding words...");
        Console.ReadLine(); // wait for user before starting

        // Main loop
        while (true)
        {
            Console.Clear();

            // Show the current scripture 
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to stop:");

            string input = Console.ReadLine();

            
            if (input == "quit")
            {
                break;
            }

            // Hide two random words each round
            scripture.HideRandomWords(2);

            // If all words are hidden, stop the program
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetRenderedText());
                Console.WriteLine();
                Console.WriteLine(" Great Scripture mastery attempt today!!!");
                break;
            }
        }
    }
}

