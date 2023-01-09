using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("I have a magic number. Can you guess what it is? ");
      
        int guess = -1;
  
        {
            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");

                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");

                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
               
            }
        
        }
    }    
}