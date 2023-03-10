using System;

public class Menu
{
    private string _choice;

    public Menu(){}

    public string MainMenu(int points)
    {
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("     1. Create New Goal\n     2. List Goals\n     3. Save Goals\n     4. Load Goals\n     5. Record Event\n     6. Delete Goal\n     7. Quit");
        Console.Write("Select a choice from the menu: ");
        _choice = Console.ReadLine();
        Console.Clear();
        return _choice;
    }      

    public void SubMenu(List<Goal> goals)
    {
        Console.WriteLine("");
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("     1. Simple Goal\n     2. Eternal Goal\n     3. Checklist Goal");
        Console.Write("What type of Goal would you like to create? ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Simple simple = new Simple();
            simple.SetName();
            simple.SetDescription();
            simple.SetPoints();
            goals.Add(simple);
            Console.WriteLine("");
        }

        if (input == "2")
        {
            Eternal eternal = new Eternal();
            eternal.SetName();
            eternal.SetDescription();
            eternal.SetPoints();
            goals.Add(eternal);
            Console.WriteLine("");
        }

        if (input == "3")
        {
            Checklist checklist = new Checklist();
            checklist.SetName();
            checklist.SetDescription();
            checklist.SetPoints();
            checklist.SetBonus(); 
            goals.Add(checklist);
            Console.WriteLine("");
        }
    }
}