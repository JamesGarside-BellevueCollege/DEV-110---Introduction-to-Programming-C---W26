# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** James Garside

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: They are added at the same time, so the arrays remain consistent with each other.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: It tracks the next open index of the roster.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: Because the full array length would go one outside of the array (because of zero-indexing).

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: Made a foreach with a string output, then printed that.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: Made new arrays and then copied the old array onto them, then sorted them (because they don't need to stay consistent).

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Learned how to make an object.
2. Learned how to make arrays of a specified size.
3. Learned how to out variables.
4.
5.

**Which loop felt most natural to use and why?**

Answer: For loops because, at least in their current state, they are just counting

## Time Spent

**Total time:** 0.75 hours

**Breakdown:**

- Planning the arrays/menu: 2 minutes
- Input validation: 1 minutes
- Add + print roster features: 30 minutes
- Sorting feature: 5 minutes
- Testing and debugging: 5 minutes
- Writing documentation: 5 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: It took the longest to add + print the roster because that was the largest part of the code.

## Reflection

**What would you do differently next time?**

Answer: I guess combine the two for loops in section 2?

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: foreach is useful for getting information out, for is useful for putting information in.
