/**************************************************************
* Course: DEV 110
* Term: Winter 2026
*
* Programmer: James Garside
* Assignment: Guess the Number
*
* Description:
* When run, askes the user for the max value, the number of rounds, and then has the user guess the number while giving feedback (either lower, or upper).
*
**************************************************************/

namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        int maxValue = ReadIntInRange("Write the maximum value of the random int (10-100): ", 10, 100);
        int numOfRounds = ReadIntInRange("Write the number of rounds (1-3): ", 1, 3);
        Random random = new Random();

        for (int round = 1; round <= numOfRounds; round++)
        {
            Console.WriteLine($"\n=== Round {round} ===");
            int roundAnswer = random.Next(1, maxValue + 1);

            int userAnswer = 0;
            int guessCount = 0;

            do
            {
                userAnswer = ReadIntInRange("Guess the number: ", 1, maxValue);
                if (userAnswer < roundAnswer)
                {
                    Console.WriteLine("Guess is too low! Try again.");
                }

                if (userAnswer > roundAnswer)
                {
                    Console.WriteLine("Guess is too high! Try again.");
                }

                guessCount++;
            }
            while (userAnswer != roundAnswer);
            Console.WriteLine($"That was the correct number! You guessed it in {guessCount} attempts.");
        }

        Console.WriteLine("Thanks for playing!");
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
}
