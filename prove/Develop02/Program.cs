using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();  //Helper Objects
        PromptGenerator promptGenerator = new PromptGenerator(); //Helper Objects
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            // ----- MENU -----
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("What is your Mood/Emotion today: ");
                string mood = Console.ReadLine();

                Console.Write("Where did this happen? (Location): ");
                string location = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._prompt = prompt;
                newEntry._response = response;
                newEntry._mood = mood;
                newEntry._location = location;


                journal.AddEntry(newEntry);
                Console.WriteLine("Thank you! Your entry was added!");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to load: ");
                string fileToLoad = Console.ReadLine();
                journal.LoadFromFile(fileToLoad);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to save: ");
                string fileToSave = Console.ReadLine();
                journal.SaveToFile(fileToSave);
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
