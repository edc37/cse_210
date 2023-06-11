using System;
namespace Mindfullness
{
    public class Breathing : Activity
    {
        public breathe(string startMessage, string endMessage, int activityTime) : base(startMessage, endMessage, activityTime)
        {
            startMessage = "Welcome to the Breathing Activity. \r\nPlease enter, in seconds, how long you'd like this activity to last";
            activityTime = Console.ReadLine();

            Activity timer = new Activity.timer(activityTime);
            Console.WriteLine(timer);
        }
    }
}