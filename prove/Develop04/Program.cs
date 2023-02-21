using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "0";

        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();
            Console.Clear();

            if (input == "1")
            {
                Breathing breathing = new Breathing();
                breathing.StartingMessage();
                breathing.RunActivity();
                breathing.EndingMessage();
            }
            if (input == "2")
            {
                Reflecting reflecting = new Reflecting();
                reflecting.StartingMessage();
                reflecting.RunActivity();
                reflecting.EndingMessage();
            }
            if (input == "3")
            {
                Listing listing = new Listing();
                listing.StartingMessage();
                listing.RunActivity();
                listing.EndingMessage();
            }
        }
    }
}