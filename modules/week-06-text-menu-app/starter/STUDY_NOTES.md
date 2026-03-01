# Week 6: Text Menu App - Study Notes

**Name:** James Garside

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: do while always runs at least once, but a while loop tests it's requirements before it runs.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: do-hile was used for int parsing because I didn't initialize my variables.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: While loop was used for the menu because I did initialize the choice variable (with 0).

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: For loops are generally used for counting, but that was uneccessary for this assignment.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: IT meant that I could do input validation with one line of code insteasd of 8.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: I used the int input that I wrote, which has a minimum and maximum value allowed.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: int.TryParse() and double.TryParse() both output a true/false, which determines if the value was properly parsed. The actual value is out'd from the method. This means you can check if an input was properly done.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: I used literally every single one of these.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: All of these.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: I prefer interpolation because that is often easier to read. I admittedly made it slightly harder because of me formatting, but it generally less annoying to read compared to concatenation.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Learned how to bug fix using tests.
2. Learned that - is right and + is left.
3. Learned that a string cannot do [] for a substring.
4.
5.

**Which loop felt most natural to use and why?**

Answer: This is a meaningless question. While loop ig.

## Time Spent

**Total time:** 3.5 hours

**Breakdown:**

- Planning the loops: 5 minutes.
- Input validation: 10 minutes
- String formatting: 1.5 hours
- Testing and debugging: 1.5 hours
- Writing documentation: 10 minutes
**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Probably string formatting because it took a while to write things completely accurately.

## Reflection

**What would you do differently next time?**

Answer: I would probably move most of the variables into the string so that interpolation is slightly easier to understand.

**How did using three different loop types improve your understanding of repetition?**

Answer: What??? repetition is obvious and learning loops changes very little about it.
