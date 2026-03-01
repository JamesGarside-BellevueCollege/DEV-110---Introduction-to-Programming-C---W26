/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: James Garside
- Assignment: Week 7: Class Roster Builder (Arrays)
-
- What does this program do?:
- Builds a class roster using parallel arrays and a simple menu.
- */

using System.Collections.Specialized;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassRoster;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Class Roster ===\n");

        int rosterCapacity = 3;
        string[] rosterNames = new string[rosterCapacity];
        int[] rosterCredits = new int[rosterCapacity];

        // Count is used to store the next open index
        int count = 0;

        int choice = 0;

        while (choice != 4)
        {
            // Print the menu options (every loop)
            Console.WriteLine("1) Add multiple students");
            Console.WriteLine("2) Print class roster");
            Console.WriteLine("3) Print roster (sorted)");
            Console.WriteLine("4) Exit");

            choice = ReadIntInRange("Choose an option: ", 1, 4);

            // Empty line for TODO 9
            Console.WriteLine(string.Empty);

            switch (choice)
            {
                case 1:

                    // Adds a specifried number of students to the roster.
                    if (count == rosterCapacity)
                    {
                        Console.WriteLine("Roster is full. Cannot add more students.");
                        break;
                    }

                    int remainingSlots = rosterCapacity - count;
                    int newSize = ReadIntInRange($"How many students do you want to add? (1-{remainingSlots}): ", 1, remainingSlots);
                    string[] newNames = new string[newSize];
                    int[] newCredits = new int[newSize];
                    for (int i = 0; i < newSize; i++)
                    {
                        Console.WriteLine($"Enter name for student {i + 1}: ");
                        newNames[i] = Console.ReadLine();
                        newCredits[i] = ReadIntInRange($"Enter credits for {newNames[i]} (0-200): ", 0, 200);
                    }

                    for (int i = 0; i < newSize; i++)
                    {
                        // These loops could be combined, but they are supposed to be seperate, so I will keep them that way.
                        rosterNames[count] = newNames[i];
                        rosterCredits[count] = newCredits[i];
                        count++;
                    }

                    Console.WriteLine("Students added.");
                    break;
                case 2:

                    // Prints roster
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                        break;
                    }

                    string[] rosterLines = BuildRosterLines(rosterNames, rosterCredits, count);
                    Console.WriteLine("Class Roster:");
                    foreach (string line in rosterLines)
                    {
                        Console.WriteLine(line);
                    }

                    break;
                case 3:

                    // Prints and sorts roster
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                        break;
                    }

                    Console.WriteLine("Sort by:");
                    Console.WriteLine("1) Name");
                    Console.WriteLine("2) Credits");

                    int sortChoice = ReadIntInRange("Select your choice: ", 1, 2);
                    string[] sortedNames;
                    int[] sortedCredits;
                    CopyUsedRoster(rosterNames, rosterCredits, count, out sortedNames, out sortedCredits);

                    if (sortChoice == 1)
                    {
                        Array.Sort(sortedNames, sortedCredits, StringComparer.OrdinalIgnoreCase);
                    }
                    else
                    {
                        // The only other value is two, so else can be used here.
                        Array.Sort(sortedCredits, sortedNames);
                    }

                    Console.WriteLine("Class Roster (Sorted):");
                    string[] sortedRosterLines = BuildRosterLines(sortedNames, sortedCredits, count);
                    foreach (string line in sortedRosterLines)
                    {
                        Console.WriteLine(line);
                    }

                    break;
                case 4:
                    Console.WriteLine("Goodbye.");
                    break;
            }
        }

        Console.WriteLine("(Starter project) Follow the TODO steps in Program.cs.");
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // Gets int input within range
        Console.Write(prompt);

        bool isValid;
        int outputInt;

        do
        {
            isValid = int.TryParse(Console.ReadLine(), out outputInt);

            if (!isValid || outputInt < min || outputInt > max)
            {
                // Explains error with reasoning
                Console.Write("ERROR: Invalid input, reason: ");

                // If there is no other error, use this.
                string output = "could not parse input.";

                if (outputInt < min)
                {
                    output = "input below minimum value.";
                }

                if (outputInt > max)
                {
                    output = "input above maximum value.";
                }

                Console.WriteLine(output);

                // Reprints prompt.
                Console.Write(prompt);
            }
        }
        while (!isValid || outputInt < min || outputInt > max);

        return outputInt;
    }

    private static string[] BuildRosterLines(string[] names, int[] credits, int count)
    {
        // Builds the roster output
        string[] returnString = new string[count];

        for (int i = 0; i < count; i++)
        {
            returnString[i] = names[i] + " " + credits[i];
        }

        return returnString;
    }

    private static void CopyUsedRoster(
        string[] sourceNames,
        int[] sourceCredits,
        int count,
        out string[] names,
        out int[] credits)
    {
        // Copies input arrays to a correctly sized array.
        names = new string[count];
        credits = new int[count];

        for (int i = 0; i < count; i++)
        {
            names[i] = sourceNames[i];
            credits[i] = sourceCredits[i];
        }
    }
}
