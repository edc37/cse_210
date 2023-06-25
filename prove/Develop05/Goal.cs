using System;
namespace Goals {
    public abstract class Goal
    {
        protected string _description = "";
        protected int _points = 0;

        // METHODS //

        public abstract Goal(string name, string description, int points);
        public Goal(string savedString)
        {

        }
        public int RecordEvent()
        {
            Console.WriteLine("Select an event to record: ");
            string record = Console.ReadLine();
            int r = Int32.Parse(record);
            return r;
        }
        public string ToSavedString()
        {
            string savedString = Console.ReadLine();
            return savedString;
        }
        public string ToString()
        {
            
        }
    }
}