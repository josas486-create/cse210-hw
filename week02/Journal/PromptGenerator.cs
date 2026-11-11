using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the most meaningful moment of your day?",
        "What is one thing you learned today?",
        "Who made you smile today, and why?",
        "What challenge did you face today, and how did you handle it?",
        "What is one thing you are grateful for today?",
        "What would you like to improve about tomorrow?",
        "What is one achievement, big or small, that made you proud today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}