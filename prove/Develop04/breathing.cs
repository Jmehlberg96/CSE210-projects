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
     for(int i = 4; i >= 0; i--)
       {
        Console.Write($"\rBreathe in: {i}");
        Thread.Sleep(1000);
       }
        Console.Write("\rBreathe in: ");
        Console.WriteLine("");
    }

    public void BreathOut()
    {
        for(int i = 6; i >= 0; i--)
       {
        Console.Write($"\rBreathe out: {i}");
        Thread.Sleep(1000);
       }
        Console.Write("\rBreathe out: ");
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