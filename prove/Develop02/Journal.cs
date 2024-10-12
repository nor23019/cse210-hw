class Journal{
    public List<Entry> Entries;

    public Journal(){                                                   //Journal constructor
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry entry){                                  //Method for adding entries to Journal
        Entries.Add(entry);
    }
    
    public void DisplayEntries(){                                       //Method for displaying entries
        foreach(var entry in Entries)
        {
            Console.WriteLine(entry.DisplayEntry());
        }
    }

    public void SaveToFile(string filename){                    
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach(var entry in Entries)
            {
              writer.WriteLine($"{entry.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")} | {entry.Content}");
            }  
        }
    }

    public void LoadFromFile(string filename){                          //Method to load entries
        Entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    DateTime timestamp = DateTime.Parse(parts[0].Trim());
                    string content = parts[1].Trim();
                    Entries.Add(new Entry(content, timestamp));
                }
            }
        }
        Console.WriteLine("Entries loaded.");
    }

}



