using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,11);

        //Console.Write("Magic number: ");
        //string magic = Console.ReadLine();
        //float magicNum = float.Parse(magic);

        Console.Write("Guess a number between 1 and 10: ");
        string guessString = Console.ReadLine();
        int guess = int.Parse(guessString);
        
        while(guess != magicNum) {

        if (guess < magicNum) {
            Console.Write("Higher. ");
        }
        else if (guess > magicNum) {
            Console.Write("Lower. ");
        }

        Console.Write("Guess again: ");
        string guessAgain = Console.ReadLine();
        guess = int.Parse(guessAgain);

        } 
        Console.Write("That's correct!");
    }
}