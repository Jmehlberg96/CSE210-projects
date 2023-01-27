using System.IO;

class Program
{
    
    static void Main(string[] args)
    {
       string userResponse = "5";
       

        do{
            Console.WriteLine();
            Console.WriteLine("Welcome to your Journal.");
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            
            Console.WriteLine();

            Journal journal = new Journal();
            Entry entry = new Entry();

            if (userResponse == "1"){
               journal.AddEntry();     
            }
            else if (userResponse == "2"){
                journal.DisplayJournal();
            }
            else if (userResponse == "3"){
                journal.LoadJournal();
            }
            else if (userResponse == "4"){
                journal.SaveJournal();
            }

        }while(userResponse != "5");


    }
    
}