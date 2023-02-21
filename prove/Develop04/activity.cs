using System;

public class Activity{
    
    protected string _actName = "";
    protected string _actDescription = "";
    protected int _seconds;
    protected DateTime _end;

    public Activity()
    {
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_actName} Activity.");
        Console.WriteLine("");
        Console.WriteLine($"{_actDescription}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _seconds = int.Parse(Console.ReadLine());
        Console.Clear();
        GetReadyMessage();
    }

    public void EndingMessage()
    {
        Console.Write("You have done a great job.");
        Spinner();
        Console.WriteLine("");
        Console.Write($"You have completed the {_actName} Activity for {_seconds} seconds.");
        Spinner();
    }

    public void Spinner()
    { int numb = 0;
       do{ 
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(@"\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        numb += 1;
       }while(numb != 4);
    }

    public void GetReadyMessage()
    {
        Console.Write("Get Ready....");
        Spinner();
        Console.WriteLine("");
        Console.WriteLine("");
    }

     public void CountDownTimer(int seconds)
    {
        DateTime start = DateTime.Now;
        _end = start.AddSeconds(seconds);    
    }
   
}