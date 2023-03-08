using System;

public class Checklist : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public Checklist() : base ()
    {
        _isComplete = false;
        _targetCount = 0;
        _currentCount = 0;
        _bonusPoints = 0;
    }

    public Checklist(string name, string description, int points,bool isComplete, int currentCount, int targetCount, int bonusPoints)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    public void  SetBonus()
    { 
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _targetCount = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    
      public override void ShowGoal(int goalNumber)
    {
         string checkString = " ";
        if (_isComplete )
        checkString = "X";
        Console.WriteLine($"{goalNumber}. [{checkString}] {_name} ({_description}) -----Currently complete {_currentCount}/ {_targetCount}");
    }

      public override void RecordEvent()
    {
        _currentCount ++;
        if(_currentCount == _targetCount){
            _isComplete = true; 
        }  
    }

     public override string GetGoalString()
    {
        string goal = $"ChecklistGoal|{_name}|{_description}|{_points}|{_isComplete}|{_currentCount}|{_targetCount}|{_bonusPoints}";
        return goal;
    }
}