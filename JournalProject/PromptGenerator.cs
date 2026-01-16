using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "Who inspired you today?",
        "What challenge did you overcome today?",
        "What are you grateful for today?",
        "What did you learn today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
