using System;

public class ListingPromptGen
{
    private List<string> _listingPrompts = new List<string>();

    public ListingPromptGen()
    {
        _listingPrompts.Add("---Who are people that you appreciate?---");
        _listingPrompts.Add("---What are personal strengths of yours?---");
        _listingPrompts.Add("---Who are people that you have helped this week?---");
        _listingPrompts.Add("---When have you felt the Holy Ghost this month?---");
        _listingPrompts.Add("---Who are some of your personal heroes?---");
    }
    
    public string GetRandomPrompt()
    {
        var countPrompt = _listingPrompts.Count();
        Random random = new Random();
        int randomInt = random.Next(0,countPrompt -1);
        string promptQ = _listingPrompts[randomInt];
        _listingPrompts.Remove(promptQ);
        return promptQ;
    }
}