using System;

class Program
{
    static void Main(string[] args)
    {
        ManageGoals manage = new ManageGoals();
        List<Goal> goals = new List<Goal>();
        int points = 0;

        while (true)
        {
            Menu menu = new Menu();
            string choice = menu.MainMenu(points);
            switch(choice)
            {
                case "1":
                    menu.SubMenu(goals);
                break;
                case "2":
                    int x = 0;
                    foreach(Goal goal in goals)
                    {
                        x++;
                        goal.ShowGoal(x);
                    }
                    Console.WriteLine("");
                break;
                case "3":
                    manage.SaveGoals(goals, points);
                    Console.WriteLine("");
                break;
                case "4":
                    manage.LoadGoals();
                    goals = manage.GetGoals();
                    points = manage.GetPoints();
                    Console.WriteLine("");
                break;
                case "5":
                    manage.GetRecordEvent(goals);
                    points = manage.GetPoints();
                break;
                case "6":
                    manage.DeleteGoal(goals);
                break;
                case "7":
                    Console.WriteLine("Thanks");
                return;

            } 
        }
    }
}