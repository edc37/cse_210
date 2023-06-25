using System;
namespace Goals
{
    public abstract class Menu
    {
        protected string description = "";
        List<string> options = new List<string>();
        protected string prompt = "";

        // METHODS //
        public abstract int GetValidInt(string prompt);
        public Menu(string description, List<string> options, string prompt)
        {

        }
        public int Show()
        {

        }
    }
}