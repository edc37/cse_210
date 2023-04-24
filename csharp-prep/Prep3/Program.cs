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

        Console.Write("Guess: ");
        string guessString = Console.ReadLine();
        int guess = int.Parse(guessString);
        
        do {

        if (guess < magicNum) {
            Console.Write("Higher. ");
        }
        else {
            Console.Write("Lower. ");
        }

        Console.Write("Guess again: ");
        string guessAgain = Console.ReadLine();
        guess = int.Parse(guessAgain);
        
        } while(guess != magicNum);
        
        Console.Write("That's correct!");
    }
}