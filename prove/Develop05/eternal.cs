using System;

public class Eternal : Goal
{
    public Eternal(): base()
    {
        _isComplete = false;
    }
         public Eternal(string name, string description, int points, bool isComplete){
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }
    
       public override void RecordEvent()
    {
    }
     public override string GetGoalString()
    {
        string goal = $"EternalGoal|{_name}|{_description}|{_points}|{_isComplete}";
        return goal;
    }
}