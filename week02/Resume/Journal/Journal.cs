using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // Use ~|~ as separator (unlikely to appear in text)
                writer.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._mood}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' not found.");
            return;
        }

        _entries.Clear();   // replace current journal as required

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
            if (parts.Length >= 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2],
                    _mood = (parts.Length > 3) ? parts[3] : ""
                };
                _entries.Add(entry);
            }
        }
    }
}