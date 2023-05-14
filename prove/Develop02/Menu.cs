using System;

    public class Menu 
    {
        public string[] menu = new string[] 
        {
            "0 - New Entry",
            "1 - Display all entries",
            "2 - Load previous entry",
            "3 - Save",
            "4 - Quit"
        };
        public void menuOutput() 
        {
            Console.WriteLine("Welcome to the Journal Application.");
            for (int i=0; i<menu.Length; i++)
            {
                Console.WriteLine($"{menu[i]}");    
            }
        }
    }