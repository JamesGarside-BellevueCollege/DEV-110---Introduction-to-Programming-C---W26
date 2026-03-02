/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: James Garside
- Assignment: Week 9: Score Stats (Methods + LINQ)
-
- What does this program do?:
- Defines a ScoreReport class students complete using LINQ methods.
- */

using System.Globalization;
using System.Linq;

namespace ScoreStats;

internal class ScoreReport
{
    private readonly int[] _scores;

    public ScoreReport(int[] scores, int threshold)
    {
        _scores = scores;
        Threshold = threshold;
    }

    public int Threshold { get; }

    public int Count => _scores.Length;

    public void PrintReport()
    {
        PrintBasicStats();
        PrintPassingFailingCounts();
        Console.WriteLine(string.Empty);
        PrintScoresSorted();
        PrintTopScores(3);
        PrintPassingScores();
        PrintFailingScores();
    }
    private void PrintBasicStats()
    {
        Console.WriteLine($"Count: {Count}");
        Console.WriteLine($"Min: {_scores.Min()}");
        Console.WriteLine($"Max: {_scores.Max()}");
        Console.WriteLine($"Average: " + _scores.Average().ToString("F1", CultureInfo.InvariantCulture));
    }
    private void PrintPassingFailingCounts()
    {
        Console.WriteLine($"Passing (>={Threshold}): {_scores.Count(score => score >= Threshold)}");
        Console.WriteLine($"Failing (<{Threshold}): {_scores.Count(score => score < Threshold)}");
    }
    private void PrintScoresSorted()
    {
        IOrderedEnumerable<int> sorted = _scores.OrderBy(score => score);
        Console.WriteLine($"Sorted (asc): {string.Join(", ", sorted)}");
    }
    private void PrintTopScores(int topCount)
    {
        IEnumerable<int> sorted = _scores.OrderByDescending(score => score).Take(topCount);
        Console.WriteLine($"Top {topCount}: {string.Join(", ", sorted)}");
    }
    private void PrintPassingScores()
    {
        IOrderedEnumerable<int> passingScores = _scores.Where(score => score >= Threshold).OrderByDescending(score => score);
        Console.WriteLine($"Passing scores (desc): {string.Join(", ", passingScores)}");
    }
    private void PrintFailingScores()
    {
        IOrderedEnumerable<int> passingScores = _scores.Where(score => score < Threshold).OrderByDescending(score => score);
        Console.WriteLine($"Failing scores (desc): {string.Join(", ", passingScores)}");
    }
}
