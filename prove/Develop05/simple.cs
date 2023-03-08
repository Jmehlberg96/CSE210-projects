using System;

public class Simple : Goal
{
    public Simple(): base()
    {
        _isComplete = false;
    } 
    
    public Simple(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;  
    }

     public override void ShowGoal(int goalNumber)
    {
        string checkString = " ";
        if (_isComplete )
        checkString = "X";
        Console.WriteLine($"{goalNumber}. [{checkString}] {_name} ({_description} )");
    }

     public override string GetGoalString()
    {
        string goal = $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
        return goal;
    }
}