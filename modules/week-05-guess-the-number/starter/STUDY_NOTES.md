# Week 5: Guess the Number - Study Notes

**Name:** James Garside

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: do-whiles always run at least once, while lopps will first check their conditions, and then run.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: i used it for validating inputs and for the logic of running the game.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I did not use one.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I did this to count the number of rounds.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: It means that it can be ran multiple times.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: Checking if the input was below the min or above the max (note that this is inclusive of 10 and 100, as I believe was your intention).

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: Same logic as above.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: by using int.tryparse and seeing if the bool was true or false????

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: Literally just do a while check for if it is not equal, and check for lower/upper. They shouldn't be if-else estatements (otherwise the correct answer would have bad text before it).

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: userGuess++;. Very simple.

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: Create a random object. Then call the object and place the output into an int variable.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: The maximum value for Random.Next is exclusive.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: Checked lower, upper, and bad inputs.

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: Accidentally tried to declare a variable twice because I slightly restructured my code.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Difference between do-while and while
2. Int.TryParse method.
3. How to correctly pull from git.
4.
5.

**Which loop felt most natural to use and why?**

Answer: for because it has been what I have been using for ages.

## Time Spent

**Total time:** 30 minutes

**Breakdown:**

- Planning the loops: 1 minute
- Input validation: 7 minutes
- Guessing logic: 3 minutes
- Testing and debugging: 10 minutes
- Writing documentation: 10 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Testing and debugging because I had a few style errors that I didn't know how to fix (it was fixed by moving the while onto a different line).

## Reflection

**What would you do differently next time?**

Answer: Laugh slightly harder that the tests.cs project fails style guidelines.

**How did using three different loop types improve your understanding of repetition?**

Answer: they didn't lol. I already knew all three loops (mostly).
