using System;
using System.IO;

public class ManageGoals
{
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;
    
    public ManageGoals(){
        _points = 0;
        _goals = new List<Goal>();
    }

    public void SaveGoals(List<Goal> goals, int points)
    {
        Console.Write("What is the name of your file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            sw.WriteLine(points);
            foreach (Goal line in goals)
            {
                sw.WriteLine(line.GetGoalString());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of your file? ");
        string fileName = Console.ReadLine();
        String line;
        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                line = sr.ReadLine();
                _points = int.Parse(line);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] goalLines = line.Split('|');
                    string goalType = goalLines[0];
                    if(goalType == "SimpleGoal")
                    {
                        Simple goal = new Simple(goalLines[1], goalLines[2],int.Parse(goalLines[3]), bool.Parse(goalLines[4]));
                        _goals.Add(goal);
                    }
                    if(goalType == "EternalGoal")
                    {
                        Eternal goal = new Eternal(goalLines[1], goalLines[2],int.Parse(goalLines[3]), bool.Parse(goalLines[4]));
                        _goals.Add(goal);
                    }
                     if(goalType == "ChecklistGoal")
                     {
                        Checklist goal = new Checklist(goalLines[1], goalLines[2],int.Parse(goalLines[3]),bool.Parse(goalLines[4]), int.Parse(goalLines[5]),int.Parse(goalLines[6]),int.Parse(goalLines[7]));
                        _goals.Add(goal);
                    }
                    line = sr.ReadLine();
                };
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception:" + e.Message);
        }
    
    }

    public List<Goal> GetGoals(){
        return _goals;
    }

    public int GetPoints(){
        return _points;
    }
    public void DeleteGoal(List<Goal> goals)
    {
       //goals.Remove(goalToDelete);
       Console.WriteLine("The goals are: ");
                int x = 0;
                foreach(Goal goal in goals)
                {
                    x++;
                    goal.ShowGoalSimple(x);
                }
                Console.Write("Which goal would you like to delete? ");
                int deleteChoice = int.Parse(Console.ReadLine());
                Goal goalToDelete = goals[deleteChoice -1];
                goals.Remove(goalToDelete);
                Console.WriteLine("");
    }
    public void GetRecordEvent(List<Goal> goals){
        Console.WriteLine("The goals are: ");
                int x = 0;
                foreach(Goal goal in goals)
                {
                    x++;
                    goal.ShowGoalSimple(x);
                }
                Console.Write("Which goal would you like to record? ");
                int input = int.Parse(Console.ReadLine());
                Goal selectedGoal = goals[input-1];
                selectedGoal.RecordEvent();
                _points = GetPoints() + selectedGoal.GetPoints();
                Console.WriteLine($"Congratulation you have earned {selectedGoal.GetPoints()}");
                Console.WriteLine($"You now have {_points}");
                Console.WriteLine("");
    }
    

}