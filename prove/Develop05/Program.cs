using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int points = 0;
        string choice = "";

        while (choice != "7")
        {
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Delete Goal");
            Console.WriteLine("     7. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                string input = "0";
                Console.WriteLine("");
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("     1. Simple Goal");
                Console.WriteLine("     2. Eternal Goal");
                Console.WriteLine("     3. Checklist Goal");
                Console.Write("What type of Goal would you like to create? ");
                input = Console.ReadLine();

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
            if (choice == "2")
            {
                int x = 0;
                foreach(Goal goal in goals)
                {
                    x++;
                    goal.ShowGoal(x);
                }
                Console.WriteLine("");
            
            }
            if (choice == "3")
            {
                ManageGoals manage = new ManageGoals();
                manage.SaveGoals(goals, points);
                Console.WriteLine("");
            }
            if (choice == "4")
            {
                ManageGoals manage = new ManageGoals();
                manage.LoadGoals();
                goals = manage.GetGoals();
                points = manage.GetPoints();
                Console.WriteLine("");
            }
            if (choice == "5")
            {
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
                points = points + selectedGoal.GetPoints();
                Console.WriteLine($"Congratulation you have earned {selectedGoal.GetPoints()}");
                Console.WriteLine($"You now have {points}");
                Console.WriteLine("");
            }
            if (choice == "6")
            {
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
                ManageGoals  manage = new ManageGoals();
                manage.DeleteGoal(goals, goalToDelete);
                Console.WriteLine("");
            }
            

        }


    }
}