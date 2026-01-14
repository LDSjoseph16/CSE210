using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> itemList = new List<int>();
        
        int inputVal = -1;
        while (inputVal != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string rawInput = Console.ReadLine();
            inputVal = int.Parse(rawInput);
            
            if (inputVal != 0)
            {
                itemList.Add(inputVal);
            }
        }

        int totalSum = 0;
        foreach (int val in itemList)
        {
            totalSum += val;
        }

        Console.WriteLine($"The sum is: {totalSum}");

        float meanResult = ((float)totalSum) / itemList.Count;
        Console.WriteLine($"The average is: {meanResult}");

        int highestNum = itemList[0];

        foreach (int val in itemList)
        {
            if (val > highestNum)
            {
                highestNum = val;
            }
        }

        Console.WriteLine($"The max is: {highestNum}");
    }
}