/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: James Garside
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        string title = "Text Menu Studio";
        string subTitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);
        int choice = 0;

        // Print text
        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subTitle);
        Console.WriteLine(divider);

        while (choice != 6)
        {
            // Formatting (performs TODO 6)
            Console.WriteLine(string.Empty);

            Console.WriteLine("""
            - 1) Greeting Card
            - 2) Name Tag Formatter
            - 3) Phrase Analyzer
            - 4) Fancy Receipt Line
            - 5) Menu Banner Builder
            - 6) Exit
            """);
            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            // Formatting
            Console.WriteLine(string.Empty);

            switch (choice)
            {
                case 1:

                    // Make a greeting card
                    Console.Write("Enter your name: ");
                    string userName = Console.ReadLine().Trim();
                    Console.Write("Enter a short message: ");
                    string message = Console.ReadLine();

                    // Formatting
                    Console.WriteLine(divider);
                    Console.WriteLine(string.Format("| Hello, {0,-38}|", userName));
                    Console.WriteLine(string.Format("| {0,-45}|", userName.ToUpper()));
                    Console.WriteLine(string.Format("| Message: {0,-36}|", message));
                    Console.WriteLine(divider);
                    break;
                case 2:

                    // Name tage formatter
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine().Trim();
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine().Trim();

                    string fullName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower() + " " + lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower();
                    char firstNameInitial = firstName[0];
                    char lastNameInitial = lastName[0];

                    // Formatting
                    Console.WriteLine(divider);
                    string fullNameFormat = fullName + "]";
                    Console.WriteLine(string.Format("| [{0,-43} |", fullNameFormat));
                    Console.WriteLine(string.Format("| Initials: {0} {1,-32} |", firstNameInitial, lastNameInitial));
                    Console.WriteLine(string.Format("| Lowercase: {0,-33} |", fullName.ToLower())); // Not certain if this is what you mean by "lower case version"
                    Console.WriteLine(divider);
                    break;
                case 3:

                    // Phrase analyzer
                    Console.Write("Enter a phrase: ");
                    string phrase = Console.ReadLine().Trim();
                    int lengthOfPhrase = phrase.Length;
                    bool containsA = phrase.ToLower().Contains('a');
                    string dashedPhrase = phrase.Replace(' ', '-');
                    string commaSeperatedPhrase = string.Join(',', dashedPhrase.Split('-'));

                    // Formatting
                    Console.WriteLine(divider);
                    Console.WriteLine(string.Format("| Length: {0,-37}|", lengthOfPhrase));
                    Console.WriteLine(string.Format("| Contains A: {0,-33}|", containsA));
                    Console.WriteLine(string.Format("| Dashed: {0,-37}|", dashedPhrase));
                    Console.WriteLine(string.Format("| Comma sep: {0,-34}|", commaSeperatedPhrase));
                    Console.WriteLine(divider);
                    break;
                case 4:

                    // Receipt Line
                    Console.Write("Enter item name: ");
                    string itemName = Console.ReadLine().Trim();
                    double price = ReadDouble("Enter price: ");
                    int quantity = ReadIntInRange("Enter quantity(1 - 9): ", 1, 9);
                    decimal total = Convert.ToDecimal(price * quantity);
                    total = Math.Round(total, 2);

                    // Formatting
                    Console.WriteLine(divider);
                    Console.WriteLine("| ITEM                    | QTY     | TOTAL    |");
                    Console.WriteLine(divider);
                    Console.WriteLine(string.Format("| {0,-24}| {1,-8}| ${2,-8:0.00}|", itemName, quantity.ToString(), total.ToString("F2")));
                    Console.WriteLine(divider);
                    Console.WriteLine(string.Format("| Total:                              {0,-9:0.00}|", "$" + total.ToString("F2")));
                    Console.WriteLine(divider);
                    break;
                case 5:

                    // Menu Banner
                    Console.Write("Enter a title: ");
                    string menuTitle = Console.ReadLine().Trim();
                    Console.Write("Enter a subtitle: ");
                    string menuSubTitle = Console.ReadLine().Trim();
                    int width = ReadIntInRange("Enter width (30-60): ", 30, 60);

                    string dividerMenu = new string('=', width);

                    // Formatting
                    Console.WriteLine("Centered");
                    Console.WriteLine(dividerMenu);
                    Console.WriteLine(string.Format("|{0}|", menuTitle.ToUpper().PadLeft((width / 2) - 1).PadRight(width - 2)));
                    Console.WriteLine(string.Format("|{0}|", menuSubTitle.PadLeft((width / 2) - 1).PadRight(width - 2)));
                    Console.WriteLine(dividerMenu);
                    Console.WriteLine("Right");
                    Console.WriteLine(dividerMenu);
                    Console.WriteLine(string.Format("| {0}|", menuTitle.ToUpper().PadRight(width - 1)));
                    Console.WriteLine(string.Format("| {0}|", menuSubTitle.PadRight(width - 1)));
                    Console.WriteLine(dividerMenu);
                    Console.WriteLine("Left");
                    Console.WriteLine(dividerMenu);
                    Console.WriteLine(string.Format("|{0} |", menuTitle.ToUpper().PadLeft(width - 1)));
                    Console.WriteLine(string.Format("|{0} |", menuSubTitle.PadLeft(width - 1)));
                    Console.WriteLine(dividerMenu);
                    break;
                case 6:

                    // Closing string analysis
                    Console.Write("Enter a closing word: ");
                    string analysisString = Console.ReadLine(); // Didn't use trim because technically the space character could be the first/last of the string.
                    bool checkGoodbye = analysisString.Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                    string analysisSubstring = analysisString.Length > 3 ? analysisString.Substring(0, 3) : analysisString;
                    bool endsExclamationPoint = analysisString.EndsWith('!');
                    int indexOfSpace = analysisString.IndexOf(' ');

                    // Formatting
                    Console.WriteLine($"| Is equal to goodbye: {checkGoodbye,-25}|");
                    Console.WriteLine($"| substring: {analysisSubstring,-35}|");
                    Console.WriteLine($"| Ends with !: {endsExclamationPoint,-33}|");
                    if (indexOfSpace == -1)
                    {
                        // Failure state
                        Console.WriteLine("| Could not locate space.                       |");
                    }
                    else
                    {
                        Console.WriteLine($"| First space at: {indexOfSpace,-30}|");
                    }

                    Console.WriteLine("\nGoodbye!");
                    break;
            }
        }
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

    private static double ReadDouble(string prompt)
    {
        // Gets a double.
        Console.Write(prompt);

        bool isValid = false;
        double outputDouble = 0;

        while (!isValid)
        {
            isValid = double.TryParse(Console.ReadLine(), out outputDouble);

            if (!isValid)
            {
                Console.WriteLine("ERROR: Invalid input, reason: could not pare input.");

                // reprints prompt
                Console.Write(prompt);
            }
        }

        return outputDouble;
    }
}
