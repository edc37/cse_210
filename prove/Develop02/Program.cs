using System;

namespace Journal {
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice <= 4){

            Console.WriteLine("Please enter the corresponding number:");
            Menu menu = new();
            menu.menuOutput();

            choice = int.Parse(Console.ReadLine());
            
            if ( choice == 0)
            {
                Entry entry = new();
                entry._entry();
            }
            else if (choice == 1)
            {
                
            }
            else
            {
                Console.WriteLine("Thank you for using the journal program.");
            }
            }

        }
    }
}