# Week 3: Personal Profile Card - Study Notes

**Name:** James Garside

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: string is an array of characters. This was sued to store things such as the name. Int is a integer (base 32). I used this for the favorite number. Double is a range of real numbers. I used this for the GPA. A boolean is either true or false. I used this to store whether the user was a full-time student.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: Double was used instead of int because the exptcted input would contain decimals.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I used a ternary operator.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: We were told to organize them into logical groups. I therefore organized them based on whether they mattered (and were personal), were strictly academic, or generally miscellaneous (although the graduation year is in there).

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: All of the above. I do not think I did anything else.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: Because it reduces redundancy.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: Formatting was by far the hardest part. I had to actually do research to get that to function.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: Looked it up on stack overflow lol.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: Hardest to understand was probably why int.Parse() failed when a double is input. I know now that it only parses strings.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: int.Parse().

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: Dividing by twelve gets the number of feet, finding the remainder is the number of inches.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: Checked if their GPA was greater than or equal to 3.5

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: It rounds doubles to 2 decimal places.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: Used an if/else statement.

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I used string.Format() for easier ones and .PadRight() for strings that had text after them.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: I think that including the birth month would be nice, because then the age in months wouldn't be inaccurate. Time to birthday is interesting, but requires re-inputting data every day, so probably BMI.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: The right data type ensures that data is stored properly. It also slightly speeds up a program and reduces the amount of memory used.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: Zawg this is berely related. Who writes their favorite color, or god forbid, their favorite number????

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. Learned more differences between int.Parse() and Convert.ToInt32()
2. Learned how to use string.Format() effectively.
3. Learned how to use .PadRight() (and left) effectively.
4.
5.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: The hardest was int because I had to do a few more conversion with it.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: The right data type ensures that data is stored properly. It also slightly speeds up a program and reduces the amount of memory used.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: Honestly, I just used the test cases.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer:  int.Parse() failed when a double is input. I know now that it only parses strings.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: Honestly, I just used the test cases.

## Time Spent

**Total time:** 2 hours

**Breakdown:**

-   Understanding data types and planning variables: 0 minutes
-   Collecting user input with correct types: 10 minutes
-   Implementing calculations: 5 minutes
-   Formatting output: 1 hour
-   Testing and debugging: 20 minutes
-   Writing documentation: 15 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Formatting output because I had to learn how to use string.Format() and .PadRight().

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: I don't think I would do anything differently. Maybe make things slightly mroe organized, but IDK.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: Proper data modelling ensures that any newiie can instantly understand what a program is doing.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: None because this is boring asl.
