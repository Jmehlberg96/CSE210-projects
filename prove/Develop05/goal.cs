using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public Goal()
    {
         _name = "";
        _description = "";
        _points = 0;
        _isComplete = false;
    }

    public void SetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.Write("What is a short description of your goal? ");
        _description = Console.ReadLine();
    }

    public void SetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {
        _isComplete = true;
    }
  
    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public virtual void ShowGoal(int goalNumber)
    {
        Console.WriteLine($"{goalNumber}. [ ] {_name} ({_description} )");
    }

    public virtual void ShowGoalSimple(int goalNumber)
    {
        Console.WriteLine($"{goalNumber}. {_name}");
    }

    public virtual string GetGoalString()
    {
        string goal = $"{_name}|{_description}|{_points}|{_isComplete}";
        return goal;
    }
}