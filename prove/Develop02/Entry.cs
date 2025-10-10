using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood;
    public string _location;

    public override string ToString()
    {
        return _date + "\n" + "Mood: " + _mood + "\n" + "Location: " + _location + "\n"
          + "Prompt: " + _prompt + "\n" + "Response: " + _response + "\n";
    }

    public string SaveToFileString()
    {
        return _date + "|" + _prompt + "|" + _response + "|" + _mood + "|" + _location;
    }

    public static Entry LoadFromFileString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry
        {
            _date = parts[0],
            _prompt = parts[1],
            _response = parts[2],
            _mood = parts[3],
            _location = parts[4],
        };
    }
}
