using System.IO;

public class Journal{

    
  public List<Entry>_entries = new List<Entry>();

    Entry entry = new Entry();

    

    public void AddEntry(){
  

         entry._date = entry.DisplayDate();
          
          string prompt = entry.GetRandomPrompt();
          Console.WriteLine($"{prompt}");
          entry._prompt = prompt;

          Console.Write("> ");
          entry._response = Console.ReadLine();
            

          _entries.Add(entry);
  }


    public void DisplayJournal(){

       Console.WriteLine();
       entry.EntryDetails();
    }



    public void LoadJournal(){

        string fileName = "journal.txt";
        _entries.Clear();
        string[] entries = System.IO.File.ReadAllLines(fileName);

        // to load the entries from a txt file
        foreach (string line in entries){
            string[] parts = line.Split(",");
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
        
    }

    public void SaveJournal(){

        string fileName = "journal.txt";

        using (StreamWriter outputFile = File.CreateText(fileName))
        {
            // to output the entries to a txt file
             for (int i = 0; i < _entries.Count; i++){
            outputFile.WriteLine(_entries[i]);
        }
        
            
        }
            
    }
}


