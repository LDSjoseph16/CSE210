using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int targetNumber = randomGenerator.Next(1, 101);

        int userGuess = -1;

        while (userGuess != targetNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (targetNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (targetNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }                    
    }
}