using System;
namespace Goals
{
    public abstract class CompletableGoal : Goal
    {
        protected bool isComplete = true;

        // METHODS //
        public CompletableGoal(string name, string description, int points)
        {

        }
        public CompletableGoal(string savedString)
        {

        }
        public string ToSavedString()
        {

        }
        public string ToString()
        {

        }
    }
}