using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared, birthYear);
    }

    // Function 1
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine()!;
        return name;
    }

    // Function 3
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine()!);
        return number;
    }

    // Function 4
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine()!);
    }

    // Function 5
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 6
    static void DisplayResult(string userName, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"\n{userName}, the square of your number is {squaredNumber}");

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"{userName}, you will turn {age} this year.");
    }
}
