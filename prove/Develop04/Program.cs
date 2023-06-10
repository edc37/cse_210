using System;
namespace Mindefullness{

    class Program
    {
        static void Main(string[] args)
        {
            List <string> menu = new List<string>();
            menu.Add("Welcome to the Mindfullness Activity. Please make a selection:");
            menu.Add("1 - Breathing Activity");
            menu.Add("2 - Reflecting Activity");
            menu.Add("3 - Listing Activity");
            
            foreach (string s in menu)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("Selection: ");
            string answer = Console.ReadLine();
        }
    }
}