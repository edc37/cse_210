using System;

    public class Entry
    {
        public void _entry()
        {
            Console.WriteLine("Today's date is:");
            Console.ReadLine();

            promptGenerator prompt = new();
            string todayPrompt = prompt.randomPrompt();
            Console.WriteLine(todayPrompt);
            Console.ReadLine();
        }
    }