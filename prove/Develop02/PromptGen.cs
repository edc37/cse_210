using System;

    public class promptGenerator
    {
        public string[] prompts = {
            "What can you learn from today?",
            "How did you see the Lord's hand in your life today?",
            "Who do you wish you spent more time with?",
            "What do you want to continue or do differently tomorrow?",
            "What made today special?",
            "What was a challenge you overcame today?",
            "Who is the most interesting person you interacted with today?",
            "What was the best part of the day?",
            "How did you seee the Lord's hand in your life today?",
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?"
        };
        public string randomPrompt()
        {
            Random rand = new();
            int index = rand.Next(0, prompts.Length);
            return prompts[index];
        }
    }