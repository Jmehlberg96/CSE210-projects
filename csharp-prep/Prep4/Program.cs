using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();

       int userNumber = -1;
       int runningTotal = 0;
       int largestNum = -1;
       int smallestNum = 100;

       Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        //add numbers to a list
        while (userNumber != 0)
        {
            Console.Write("Enter a number. ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)

                numbers.Add(userNumber);
        }

        //compute the running total of the list
        foreach (int number in numbers)
        {
            runningTotal += number;
        }
        Console.WriteLine($"Your sum is {runningTotal}.");

        //compute the average of the list
        int count = numbers.Count;
        int average = runningTotal / count;

        Console.WriteLine($"The average of your numbers is {average}.");

        foreach (int number in numbers)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        Console.WriteLine($"The largest number is {largestNum}.");

        foreach (int number in numbers)
        {
            if (number < smallestNum)
            {
                if (number > 0)
                {
                    smallestNum = number;
                }
            }  
        }
        Console.WriteLine($"The smallest positive number is {smallestNum}.");

        numbers.Sort();
        Console.WriteLine("These are the numbers sorted.");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
