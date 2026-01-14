using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradeValue = int.Parse(userInput);

        string gradeLetter = "";

        if (gradeValue >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeValue >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeValue >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeValue >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");
        
        if (gradeValue >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}