using System;

class Program
{
    static void Main(string[] args)
    {
        ShowGreeting();

        string personName = GetPlayerName();
        int favoriteValue = GetPlayerNumber();

        int resultSquare = ComputeSquare(favoriteValue);

        ShowFinalOutput(personName, resultSquare);
    }

    static void ShowGreeting()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetPlayerName()
    {
        Console.Write("Please enter your name: ");
        string playerName = Console.ReadLine();

        return playerName;
    }

    static int GetPlayerNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int playerNum = int.Parse(Console.ReadLine());

        return playerNum;
    }

    static int ComputeSquare(int inputNum)
    {
        int finalResult = inputNum * inputNum;
        return finalResult;
    }

    static void ShowFinalOutput(string nameLabel, int squareLabel)
    {
        Console.WriteLine($"{nameLabel}, the square of your number is {squareLabel}");
    }
}