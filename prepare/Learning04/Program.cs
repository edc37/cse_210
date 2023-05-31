using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignmentTest = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(assignmentTest.GetSummary());

            Console.WriteLine();
            
            MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetHomeworkList());

            Console.WriteLine();

            WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "English", "The Causes of World War II");
            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingInfo());
        }
    }
}