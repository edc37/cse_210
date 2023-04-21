using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        float grade = float.Parse(gradeString);
        string letter = "";

        if (grade >= 90) {
            letter = "A";
        }
        else if (grade >= 80) {
            letter = "B";
        }
        else if (grade >= 70) {
            letter = "C";
        }
        else if (grade >= 60) {
            letter = "D";
        }
        else if (grade <= 50) {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (grade >= 70) {
            Console.WriteLine("Congrats, you passed the class!");
        }
        else {
            Console.WriteLine("You liked the class so much you wanted to take it twice.");
        }


    }
}