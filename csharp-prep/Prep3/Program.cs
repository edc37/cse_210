using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Magic number: ");
        string magic = Console.ReadLine();
        float magicNum = float.Parse(magic);

        Console.Write("Guess: ");
        string guessString = Console.ReadLine();
        float guess = float.Parse(guessString);

        if (guess < magicNum) {
            Console.Write("Higher");
        }
        else if (guess > magicNum) {
            Console.Write("Lower");
        }
        else {
            Console.Write("That's correct!");
        }
    }
}