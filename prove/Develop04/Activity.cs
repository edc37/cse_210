using System;
namespace Mindfullness
{
    public class Activity
    {
        // -----VARIABLES----- //
        protected string _startMessage = "";
        protected string _endMessage = "";
        protected int _activityTime = 0;

        // -----TIMER----- //
        public void timer(int _activityTime)
        {
            Console.WriteLine("Starting Timer");

            for (int i = _activityTime; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        
            Console.WriteLine("Done");
        }

        // -----SPINNER----- //
        public void spinner(int _activityTime)
        {
            Console.WriteLine("Starting Spinner");

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(10);

            int i = 0;

            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }

            Console.WriteLine("Done");
        }

        // -----START/END MESSAGE----- //
        public Activity(string startMessage, string endMessage, int activityTime)
        {
            _startMessage = startMessage;
            _endMessage = endMessage;
            _activityTime = activityTime;
        }
        public string GetStartMessage()
        {
            return _startMessage;
        }
        public string GetEndMessage()
        {
            return _endMessage;
        }
        public int GetActivityTime()
        {
            return _activityTime;
        }
    }
}