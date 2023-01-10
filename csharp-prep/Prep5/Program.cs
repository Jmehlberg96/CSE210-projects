using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
    

        string userName = DisplayUserName();
        int userNumber = FavoriteNumber();
        int sqNumber = SquareNumber(userNumber);

        DisplayResults(userName, sqNumber);




        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Class.");
        }

        static string DisplayUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int FavoriteNumber()
        {
            Console.Write("What is your favorite number? ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int sqNumber = userNumber * userNumber;
            return sqNumber;
        }

        static void DisplayResults(string userName, int sqNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {sqNumber}.");
        }
    }
}