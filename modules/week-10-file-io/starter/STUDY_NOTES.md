# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** James Garside

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: It returns an array of strings. Each string was converted into a Habit type.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: It would return an empty string.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: The path argument describes the path (relative to the program) and then writes the array of strings there.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: It selects every habit, converts it into the expected format for saving, and then converts that into an array.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: It means that C# tries to read/write to a file that does not exist.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: It means that only that exception is caught, rather than other exceptions. It also means I know that this si the specific exception that is occuring.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. Learned a lot about file reading in C#.
2. Learned a lot about file writing in C#.
3. Learned how to use Linq much more effectively.

**What was the trickiest part of this assignment and how did you work through it?**

Answer: accidentally writing lines instead of line and trying to bugfix a method that was working with an array input instead of a string.

## Time Spent

**Total time:** 1 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 2 minutes
- Implementing LoadHabits: 5 minutes
- Implementing PrintHabits / PrintSummary: 10 minutes
- Implementing AddHabit / UpdateHabit / SaveHabits: 20 minutes
- Testing and debugging: 20 minutes
- Writing study notes: 10 minutes

**Most time-consuming part:**

Answer: Implementing AddHabit / UpdateHabit / SaveHabits
