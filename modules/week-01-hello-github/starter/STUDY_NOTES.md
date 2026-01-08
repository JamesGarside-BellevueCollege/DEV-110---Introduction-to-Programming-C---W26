# Week 1: Hello, GitHub - Study Notes

**Name: James Garside**

## Development Environment Setup

**Software installed and versions:**
[List each piece of software you installed: .NET SDK, Visual Studio Code, Git, and any VS Code extensions]

Answer: I installed the .NET SDK and two of the VS Code extensions (EditorConfig and Better Comments)

**Operating system:**
[What OS are you using? Windows, macOS, or Linux?]

Answer: Windows

## Challenges and Solutions

**Biggest challenge during setup:**
[What was the hardest part? Installing software, configuring VS Code, understanding the terminal, or something else?]

Answer: The hardest challenge was writing the directory to git bash, because I do not know if there is a way to copy text into there.

**How you solved it:**
[Explain what you did to overcome the challenge - search online, ask for help, restart your computer, etc.]

Answer: I wrote the directory.

**Most confusing concept:**
[What was hardest to understand? Git commands, terminal navigation, C# syntax, or dotnet CLI?]

Answer: dotnet CLI ig.

## Understanding C# Basics

**What does `Console.WriteLine()` do?**
[Explain in your own words what this command does]

Answer: Well first, it doesn't work for this assignment (because it adds invisible characters after?). But what it does is print some text to the console and ends it with a line break.

**What is the purpose of `Program.cs`?**
[Why is this file important in a C# project?]

Answer: It's the entry point for the project.

**What does `dotnet run` do?**
[Explain what happens when you run this command]

Answer: It builds the project (if necessary) and then runs the built project.

## Git Workflow Understanding

**What is the difference between `git add`, `git commit`, and `git push`?**
[Explain each command and when you would use it]

Answer: `git add` pushes changes to the staging area. `git commit` moves the staging area into the commit area (which is more permanent). `git push` moves the commit area to the actual repository. It also can contain a description of the commit.

**Why do we create branches?**
[Explain the purpose of creating a student branch]

Answer: This makes it so that the main branch is unaffected by any changes made on this branch. This allows for the program to break in the branch, but not on main.

## What I Learned

**Key takeaways from this week:**
[What are the 3 most important things you learned?]

1. Learned about `git push`
2. Learned about `git add`
3. Learned about `git commit`

**How this connects to professional development:**
[Why are these skills important for programmers?]

Answer: Git is frequently used by developers; therefore, learning how to use Github will help me in the future.

## Time Spent

**Total time:** 0.6 hours

**Breakdown:**

-   Installing and configuring software: 0.05 hours
-   Learning terminal/command line basics: 0 hours
-   Writing the "Hello, GitHub!" program: 0.02 hours
-   Understanding Git workflow: 0.12 hours
-   Testing and fixing issues: 0.31 hours (from trying to get tests to work)
-   Writing documentation: 0.05 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: It used to be understanding Git workflow because that is what I know the least about. It is now about the tests feature, because the regex for key takeaways checks that the first word after the number is 3 or more characters long. A better test would be "1\.(\s+\w+){3,}", because that checks for three words.
