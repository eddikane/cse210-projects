using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int input = -1; // something that isn"t zero

        while (input != 0)
        {
            Console.Write("Enter a number (Type 0 to quit): ");
            input = int.Parse(Console.ReadLine()!);

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"\nThe sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        numbers.Sort();
        Console.WriteLine("\nSorted list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}