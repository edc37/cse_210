using System;
namespace Mindfullness
{
    public class Breathing : Activity
    {
        public breathe(string startMessage, string endMessage) : base(startMessage, endMessage)
        {
            startMessage = "Welcome to the Breathing Activity.";
        }
    }
}