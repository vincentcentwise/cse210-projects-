using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public int _wordCount;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _prompt = prompt;
        _response = response;
        _wordCount = CountWords(response);
    }

    private int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        return text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Word Count: {_wordCount}");
        Console.WriteLine("-------------------------------------------");
    }

    // Converts the entry to a CSV-formatted string
    public string ToCsv()
    {
        return $"\"{_date}\",\"{_prompt.Replace("\"", "\"\"")}\",\"{_response.Replace("\"", "\"\"")}\",{_wordCount}";
    }

    // Reads a CSV-formatted line back into an Entry object
    public static Entry FromCsv(string csvLine)
    {
        var parts = csvLine.Split("\",\"");
        string date = parts[0].Trim('"');
        string prompt = parts[1];
        string response = parts[2];
        int wordCount = int.Parse(parts[3].Trim('"'));

        Entry e = new Entry(prompt, response);
        e._date = date;
        e._wordCount = wordCount;
        return e;
    }
}
