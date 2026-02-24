# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** James Garside

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: I made ReadNonEmptyString, which reads strings that are not empty, also ReadIntInRange, which returns in int in range, and ReadYesNo, which reads for yes and no. If not that, then template and Logger. Logger can log information and template is an object for the project.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: It means that information can be stored in a seperate directory.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: It is used to store the template and information about that template (like the prompts and title). It also can format the template.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: It meant that one object could be used for multiple different templates, improving code reusability.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: I put a breakpoint in the GnerateStory function.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: I saw how my code really worked under the hood.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: This is a lie because I did not encounter any logic issues/bugs (besides formatting ones). I found an error where values other than "y" or "n" would be accepted because of faulty input validation.

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1\.\s\www Learned how to make a larger namespace.
2\.\s\www Learned how to make object classes.
3\.\s\www  how to make a new object in the code (not the actual creation of the object class).
Sorry for formatting here. Tests broke AGAIN.

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: Breaking into methods

## Time Spent

\Total time:\s\d
**Total time:** 1 hours

**Breakdown:**

- Planning structure (methods/classes): 7 minutes
- Input validation: 10 minutes
- Story templates + formatting: 30 minutes
- Testing and debugging: 7 minutes
- Writing documentation: 20 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Story templates + formatting because I had to write the most for that.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: Add more templates ig.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: It didn't lol. Normally it would mean that I could find the eorrs in individual functions/objects, but it did not help in this case
