using System;
namespace Mindfullness{

    class Program
    {
        static void Main(string[] args)
        {
            List <string> menu = new List<string>();
            menu.Add("Welcome to the Mindfullness Activity. Please make a selection:");
            menu.Add("1 - Breathing Activity");
            menu.Add("2 - Reflecting Activity");
            menu.Add("3 - Listing Activity");
            menu.Add("4 - Exit");
            
            foreach (string s in menu)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("Selection: ");
            string answer = Console.ReadLine();

            //-----Breathing-----//
            if (answer == "1")
            {
                Console.WriteLine("Breathe");
            }
            //-----Reflecting-----//
            else if (answer == "2")
            {
                Console.WriteLine("Reflect");
            }
            //-----List-----//
            else if (answer =="3")
            {
                Console.WriteLine("List");
            }
            else
            {
                Console.WriteLine("Bye");
            }
        }
    }
}