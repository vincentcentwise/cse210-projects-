using System;

/// <summary>
/// JOURNAL PROGRAM
/// ----------------
/// This program allows users to write, view, save, and load journal entries.
/// Each entry includes a random prompt, date, and word count.
/// 
/// EXCEEDS REQUIREMENTS:
/// - Entries saved in CSV format (Excel compatible)
/// - Includes word count analysis
/// - Uses OOP abstraction with separate classes for Journal, Entry, and PromptGenerator
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("=== Journal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    Entry entry = new Entry(prompt, response);
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry recorded!\n");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save (e.g., journal.csv): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load (e.g., journal.csv): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.WriteLine("Goodbye! Keep journaling!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1-5.\n");
                    break;
            }
        }
    }
}

