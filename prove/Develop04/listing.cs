using System;

public class Listing : Activity {

    private ListingPromptGen _promptGen;

    public Listing() : base()
    {
        _actName = "Listing";
        _actDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _seconds = 0;
        _promptGen = new ListingPromptGen();
    }
    
    public void DisplayRandomPrompt()
    {
        string rPrompt = _promptGen.GetRandomPrompt();
        Console.WriteLine(rPrompt); 
    }

    public void RunActivity()
    {
        CountDownTimer(_seconds);
        int count = 0;
        DisplayRandomPrompt();
        DateTime currentTime = DateTime.Now;
        while(currentTime < _end)
        {
            Console.Write(">");
            Console.ReadLine();
            count += 1;
            currentTime = DateTime.Now; 
        }
        Console.WriteLine("");
        Console.WriteLine($"You listed {count} things!");
        Console.WriteLine("");
    }
    
}