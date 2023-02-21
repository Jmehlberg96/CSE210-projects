using System;

public class Reflecting : Activity
{
    private string _prompt;
    private string _question;
    private ReflectingGen _promptGen;
    private QuestionGen _questionGen;

    public Reflecting() : base ()
    {
        _actName = "Reflecting";
        _actDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _seconds = 0;
        _prompt = "";
        _question = "";
        _promptGen = new ReflectingGen();
        _questionGen = new QuestionGen();

    }

    public void DisplayRandomPrompt()
    {

        _prompt = _promptGen.PullRandomPrompt();
        Console.WriteLine(_prompt);
        
    }
    
    public void DisplayRandomQuestion()
    {
        _question = _questionGen.GetRandomQuestion();
        Console.WriteLine(_question);
    }

    public void RunActivity()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        DisplayRandomPrompt();
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.WriteLine("");
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("");

        Console.Write("You may begin in: ");
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
        Console.Clear();

        CountDownTimer(_seconds);
        DateTime currentTime = DateTime.Now;
        while(currentTime < _end)
        {
            DisplayRandomQuestion();
            Spinner();
            currentTime = DateTime.Now; 
            Console.WriteLine("");
        }

    }
}