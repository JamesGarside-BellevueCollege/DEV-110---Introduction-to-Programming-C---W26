/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: James Garside
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Represents a Mad Libs story template with prompts and story text.
- */

namespace MadLibs;

public class StoryTemplate
{
    public StoryTemplate(string title, string[] prompts, string templateText)
    {
        Title = title;
        Prompts = prompts;
        TemplateText = templateText;
    }

    public string Title { get; }

    public string[] Prompts { get; }

    public string TemplateText { get; }

    public string GenerateStory(string[] words)
    {
        // This if should never occur.
        if (words.Length != Prompts.Length)
        {
            throw new ArgumentOutOfRangeException();
        }

        return FormatStory(words);
    }

    private string FormatStory(string[] words)
    {
        // I genuinely do not understand why this needs to be a function.
        return string.Format(TemplateText, words);
    }
}
