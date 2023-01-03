using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userImput = Console.ReadLine();
        int grade = int.Parse(userImput);
        string letter = ("");
        string sign = ("");

        if (grade >= 90)
        {
            letter = ("A");
            if (grade < 93)
            {
                sign = ("-");
            }
            
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = ("B");
            if (grade >= 87)
            {
                sign = ("+");
            }
            else if (grade < 83)
            {
                sign = ("-");
            }
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = ("C");
            if (grade >= 77)
            {
                sign = ("+");
            }
            else if (grade < 73)
            {
                sign = ("-");
            }
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = ("D");
            if (grade >= 67)
            {
                sign = ("+");
            }
            else if (grade < 63)
            {
                sign = ("-");
            }
        }
        else 
        {
            letter = ("F");
        }


        {
            Console.WriteLine($"Your grade is an {letter}{sign}.");
        }


        if (grade >= 70)
        {
            Console.WriteLine("Congratulations. You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry. You did not pass. Try harder next time.");
        }


    }
}