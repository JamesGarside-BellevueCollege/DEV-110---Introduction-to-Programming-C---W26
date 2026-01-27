/**************************************************************
* Course: DEV 110
* Term: Winter 2026
*
* Programmer: James Garside
* Assignment: Hello Github
*
* Description:
* When run, askes the user for information and then formats it into a profile card.
*
**************************************************************/

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // Collect PERSONAL INFORMATION (strings)
        Console.Write("Input your full name: ");
        string userName = Console.ReadLine();
        Console.Write("Input your city and state: ");
        string userLocation = Console.ReadLine();
        Console.Write("Input your favorite color: ");
        string userFavColor = Console.ReadLine();
        Console.Write("Input your dream job: ");
        string userDreamJob = Console.ReadLine();

        // Collect ACADEMIC INFORMATION
        Console.Write("Input your major/field of study: ");
        string userMajor = Console.ReadLine();
        Console.Write("Input your GPA: ");
        double userGPA = double.Parse(Console.ReadLine());
        Console.Write("Input your graduation year: ");
        int userGradYear = int.Parse(Console.ReadLine());
        Console.Write("Are you a full time student (yes/no): ");

        // Inline test. Check if it is yes, in which case it is true. Otherwise false.
        bool userFullTimeStudent = Console.ReadLine().ToLower() == "yes" ? true : false;

        // Collect ADDITIONAL DETAILS
        Console.Write("Input your age (in years): ");
        int userAge = int.Parse(Console.ReadLine());
        Console.Write("Input your height (in inches): ");
        double userHeight = double.Parse(Console.ReadLine());
        Console.Write("Input your favorite number (only integers are accepted): ");
        int userFavInt = int.Parse(Console.ReadLine());

        // CALCULATE derived information
        DateTime currentYear = DateTime.Now;
        int userBirthYear = currentYear.Year - userAge;
        int userGraduateAfterYears = userGradYear - currentYear.Year;
        int userFeet = Convert.ToInt32(Math.Floor(userHeight / 12));
        double userInches = userHeight % 12;
        string inHonorsFormat = userGPA >= 3.5 ? "✓" : "𐄂";
        int userAgeMonths = userAge * 12;

        // DISPLAY formatted profile card
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║           STUDENT PROFILE CARD             ║");
        Console.WriteLine("║                                            ║");
        Console.WriteLine("║           PERSONAL INFORMATION             ║");

        // Personal Information
        Console.WriteLine(string.Format("║  NAME: {0,-36}║", userName));
        Console.WriteLine($"║  AGE: {userAge} YEARS OLD".PadRight(45) + "║");
        Console.WriteLine($"║  HEIGHT: {userFeet} FEET, {userInches} INCHES".PadRight(45) + "║");
        Console.WriteLine($"║  LOCATION: {userLocation}".PadRight(45) + "║");
        Console.WriteLine(string.Format("║  DREAM JOB: {0,-31}║", userDreamJob));

        // Academic details
        Console.WriteLine("║                                            ║");
        Console.WriteLine("║              ACADEMIC DETAILS              ║");
        Console.WriteLine(string.Format("║  MAJOR: {0,-35}║", userMajor));
        Console.WriteLine($"║  LOCATION: {userGPA:F2}".PadRight(45) + "║");
        Console.WriteLine(string.Format("║  EXPECTED GRADUATION: {0,-21}║", userGradYear));
        if (userFullTimeStudent)
        {
            Console.WriteLine("║  FULL TIME STUDENT                         ║");
        }
        else
        {
            Console.WriteLine("║  PART TIME STUDENT                         ║");
        }

        Console.WriteLine(string.Format("║  IN HONORS: {0}                              ║", inHonorsFormat));

        // miscellaneous statistics
        Console.WriteLine("║                                            ║");
        Console.WriteLine("║         MISCELLANEOUS STATISTICS           ║");
        Console.WriteLine(string.Format("║  BIRTH YEAR: {0,-30}║", userBirthYear));
        if (userGraduateAfterYears != 1)
        {
            Console.WriteLine($"║  GRADUATE IN {userGraduateAfterYears} YEARS".PadRight(45) + "║");
        }
        else
        {
            Console.WriteLine($"║  GRADUATE IN {userGraduateAfterYears} YEAR".PadRight(45) + "║");
        }

        Console.WriteLine(string.Format("║  AGE IN MONTHS: {0,-27}║", userAgeMonths));
        Console.WriteLine(string.Format("║  FAVORITE COLOR: {0,-26}║", userFavColor));
        Console.WriteLine(string.Format("║  FAVORITE NUMBER: {0,-25}║", userFavInt));

        // Complete formatting
        Console.WriteLine("║                                            ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
