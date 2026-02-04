using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding"),
            new Scripture(new Reference("Alma", 32, 21), "And now as I said concerning faith faith is not to have a perfect knowledge of things"),
            new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought doubt not fear not"),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me")
        };

        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[randomIndex];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            
            if (selectedScripture.IsCompletelyHidden()) break;

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit") break;

            selectedScripture.HideRandomWords(3);
        }
    }
}