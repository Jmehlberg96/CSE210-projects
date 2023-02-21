using System;

public class Breathing : Activity
{
    public Breathing() : base()
    {
        _actName = "Breathing";
        _actDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _seconds = 0;
    }

    public void BreathIn()
    {
            Console.Write("Breathe in....");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine(""); 
    }

    public void BreathOut()
    {
            Console.Write($"Breathe out...." );
            Console.Write("6");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
            Console.WriteLine("");
    }

    public void RunActivity()
    {
        CountDownTimer(_seconds);
        DateTime currentTime = DateTime.Now;
        while(currentTime < _end)
        {
            BreathIn();
            BreathOut();
            currentTime = DateTime.Now; 
            Console.WriteLine("");
        }
    }
    
}