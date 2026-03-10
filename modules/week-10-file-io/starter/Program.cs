/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: James Garside
 * Assignment: Week 10: Habit Tracker (File I/O)
 *
 * What does this program do?:
 * A menu-driven Habit Tracker that loads habits from a CSV file and lets you
 * view, add, update, and save your habits back to disk.
 * ******************************************************************************/

using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;

namespace HabitTracker;

/// <summary>
/// Main program class for the Habit Tracker application.
/// Your work this week: implement the eight TODO methods below.
/// The Main method, menu loop, and ReadIntInRange helper are fully provided.
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point — prompts for file paths, loads habits, then runs the menu.
    /// Fully provided; no changes needed here.
    /// </summary>
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Habit Tracker: File I/O ===");
        Console.WriteLine();

        // Prompt for the path to the habits CSV file
        Console.Write("Enter habits file path: ");
        string path = (Console.ReadLine() ?? string.Empty).Trim();
        Console.WriteLine();

        // Load all habits (you will implement LoadHabits below)
        List<Habit> habits = LoadHabits(path);

        Console.WriteLine();

        // Menu loop — keeps running until the user chooses Save & Quit
        bool running = true;
        while (running)
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. View Habits");
            Console.WriteLine("2. View Summary");
            Console.WriteLine("3. Add Habit");
            Console.WriteLine("4. Update Habit");
            Console.WriteLine("5. Save & Quit");
            Console.Write("Choice (1-5): ");

            int choice = ReadIntInRange(1, 5);
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    PrintHabits(habits);
                    break;
                case 2:
                    PrintSummary(habits);
                    break;
                case 3:
                    AddHabit(habits);
                    break;
                case 4:
                    UpdateHabit(habits);
                    break;
                case 5:
                    SaveHabits(path, habits);
                    running = false;
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }

    private static List<Habit> LoadHabits(string path)
    {
        // Loads habits from the specified csv
        List<Habit> habits = new List<Habit>();
        try
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(",");
                    string name = parts[0].Trim();
                    bool status = parts[1].Trim().Equals("done", StringComparison.OrdinalIgnoreCase);
                    string frequency = parts[2].Trim();
                    habits.Add(new Habit(name, status, frequency));
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File not found — {path}");
        }

        return habits;
    }

    private static void PrintHabits(List<Habit> habits)
    {
        Console.WriteLine("--- Your Habits ---");
        habits.ForEach(indi => indi.DisplayInfo());
    }

    private static void PrintSummary(List<Habit> habits)
    {
        // Generates a summary based on completion percentage of each habit type
        Console.WriteLine("--- Summary ---");
        int daily = habits.Count(h => h.Frequency == "daily");
        if (daily == 0)
        {
            Console.WriteLine("Daily:    N/A (no daily tasks)");
        }
        else
        {
            int completedDaily = habits.Count(h => h.Frequency == "daily" && h.IsCompleted);
            decimal rate = completedDaily * 100 / daily;
            Console.WriteLine($"Daily:    {completedDaily}/{daily} completed ({rate.ToString("F1", CultureInfo.InvariantCulture)}%)");
        }

        int weekly = habits.Count(h => h.Frequency == "weekly");
        if (weekly == 0)
        {
            Console.WriteLine("Weekly:   N/A (no weekly tasks)");
        }
        else
        {
            int completedWeekly = habits.Count(h => h.Frequency == "weekly" && h.IsCompleted);
            decimal rate2 = completedWeekly * 100 / weekly;
            Console.WriteLine($"Weekly:   {completedWeekly}/{weekly} completed ({rate2.ToString("F1", CultureInfo.InvariantCulture)}%)");
        }
    }

    private static void AddHabit(List<Habit> habits)
    {
        // Adds a habit of specified name and freqency (defaults to weekly)
        Console.WriteLine("--- Add Habit ---");
        Console.Write("Habit name: ");
        string name = Console.ReadLine().Trim();

        Console.Write("Frequency ((D)aily or(W)eekly): ");
        string frequencyEval = Console.ReadLine().Trim().ToUpper();

        // Weekly is the initial, so it always works.
        string frequency = "weekly";
        if (frequencyEval == "D")
        {
            frequency = "daily";
        }

        habits.Add(new Habit(name, false, frequency));
        Console.WriteLine($"Added: {name} ({frequency})");
    }

    private static void UpdateHabit(List<Habit> habits)
    {
        // Allows the changing of the name of a specified habit and swaps whether it is completed.
        int lenOfHabits = habits.Count();

        // Checks for failure
        if (lenOfHabits == 0)
        {
            Console.WriteLine("Print: No habits to update.");
            return;
        }

        Console.WriteLine("--- Update Habit ---");
        for (int i = 0; i < lenOfHabits; i++)
        {
            Console.WriteLine($"{i + 1}. {habits[i].Name}");
        }

        Console.Write("Enter habit number: ");
        int index = ReadIntInRange(1, lenOfHabits) - 1;
        Console.Write($"New name (press Enter to keep \"{habits[index].Name}\"): ");
        string newName = Console.ReadLine().Trim();
        if (!string.IsNullOrEmpty(newName))
        {
            habits[index].Name = newName;
        }

        habits[index].IsCompleted = !habits[index].IsCompleted;
        Console.WriteLine($"Updated: {habits[index].Name} — now {(habits[index].IsCompleted ? "completed" : "pending")}");
    }

    private static void SaveHabits(string path, List<Habit> habits)
    {
        // Saves habits
        try
        {
        string[] lines = habits.Select(h => $"{h.Name},{(h.IsCompleted ? "done" : "pending")},{h.Frequency}").ToArray();
        File.WriteAllLines(path, lines);
        Console.WriteLine($"Habits saved to {path}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File not found — {path}");
        }
    }

    /// <summary>
    /// Reads an integer from the console, repeating until a valid value
    /// in [min, max] is entered. Fully provided — no changes needed.
    /// </summary>
    private static int ReadIntInRange(int min, int max)
    {
        while (true)
        {
            string line = (Console.ReadLine() ?? string.Empty).Trim();
            if (int.TryParse(line, out int value) && value >= min && value <= max)
            {
                return value;
            }

            Console.Write($"Please enter a number between {min} and {max}: ");
        }
    }
}
