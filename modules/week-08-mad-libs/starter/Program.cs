/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: James Garside
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.Marshalling;

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        // Code was just left in here, and it works... So I am gonna use it.
        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    private static StoryTemplate ChooseTemplate()
    {
        Console.WriteLine("1) Debugging at the Zoo");
        Console.WriteLine("2) The Standup Meeting");

        int chosenTemplate = ReadIntInRange("Choose a template(1 - 2): ", 1, 2);

        // Couldn't be bothered to move the init of the template out of the ifs.
        if (chosenTemplate == 1)
        {
            string[] inputPrompts = [
                "Enter an adjective: ",
                "Enter an animal(plural): ",
                "Enter a verb ending in -ing: ",
                "Enter a programming language: ",
                "Enter a debugging tool(example: breakpoint): ",
                "Enter a number: ",
                "Enter an emotion: ",
                "Enter an exclamation: "
                ];

            StoryTemplate returnedTemplate = new StoryTemplate(
                title: "Debugging at the Zoo",
                prompts: inputPrompts,
                templateText: "Today I visited the {0} zoo. I saw {1} {2} while writing {3}. I used a {4} {5} times until the bug disappeared. I felt {6} and yelled, \"{7}\"");
            return returnedTemplate;
        }
        else
        {
            // Only other option is two.
            string[] inputPrompts = [
                "Enter a name: ",
                "Enter an adjective: ",
                "Enter a noun: ",
                "Enter a verb(past tense): ",
                "Enter a number: ",
                "Enter a plural noun: ",
                "Enter a type of bug(example: null reference): ",
                "Enter a snack: "
                ];

            // This story sucks because I am not a writer.
            StoryTemplate returnedTemplate = new StoryTemplate(
                title: "The Standup Meeting",
                prompts: inputPrompts,
                templateText: "Hello {0}! I am excited to meet with you regarding my {1} {2}. I have been {3} on it for {4} nights. Multiple {5} have died to fix the dreaded {6}. Since you're ready, I hope you don't mind if I have a {7}? Thank you.");
            return returnedTemplate;
        }
    }

    private static string[] CollectWords(StoryTemplate template)
    {
        int promptLength = template.Prompts.Length;

        Logger.Info($"Collecting {promptLength} words for: {template.Title}");
        string[] madLibswords = new string[promptLength];

        for (int i = 0; i < promptLength; i++)
        {
            madLibswords[i] = ReadNonEmptyString(template.Prompts[i]);
        }

        Console.WriteLine();
        return madLibswords;
    }

    private static bool ReadYesNo(string prompt)
    {
        // Checks for y/n inputs, returns bool.
        bool isValid = false;
        bool outputBool = false;
        string interimChecker;

        // Technically I could move the return to inside the while loop, but I didn't bother.
        do
        {
            Console.Write(prompt);

            interimChecker = Console.ReadLine() ?? "empty";
            if (interimChecker == "y")
            {
                isValid = true;
                outputBool = true;
            }
            else if (interimChecker == "n")
            {
                isValid = true;
                outputBool = false;
            }

            if (!isValid)
            {
                Console.WriteLine("\nERROR: input could not be validated. Please enter (y/n)");
            }
        }
        while (!isValid);

        return outputBool;
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

                string output = string.Empty;

                if (outputInt < min)
                {
                    output = "input below minimum value.";
                }

                if (outputInt > max)
                {
                    output = "input above maximum value.";
                }

                if (!isValid)
                {
                    output = "could not parse input.";
                }

                Console.WriteLine(output);

                // Reprints prompt.
                Console.Write(prompt);
            }
        }
        while (!isValid || outputInt < min || outputInt > max);

        return outputInt;
    }

    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            // Infinite loop until valid output
            Console.Write(prompt);
            string outputString = Console.ReadLine() ?? string.Empty;
            outputString = outputString.Trim();

            if (outputString != string.Empty)
            {
                return outputString;
            }
        }
    }
}
