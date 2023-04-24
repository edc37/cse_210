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
        
        do {
        if (guess < magicNum) {
            Console.Write("Higher");
        }
        else if (guess > magicNum) {
            Console.Write("Lower");
        }
        else {
            Console.Write("That's correct!");
        }
        Console.Write("Guess again: ");
        string guessAgain = Console.ReadLine();
        guess = float.Parse(guessAgain);
        } while(guess != magicNum);
    }
}