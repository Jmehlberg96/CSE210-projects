using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First Name? ");
        string firstname = Console.ReadLine();
        
        Console.Write("What is your Last Name? ");
        string lastname = Console.ReadLine();
        
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}