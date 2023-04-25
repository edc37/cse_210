using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        float fave = PromptUserNumber();
        float square = SquareNumber(fave);

        DisplayResult(name, fave, square);
    }
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName() {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static float PromptUserNumber() {
        Console.WriteLine("Please enter your favorite  number: ");
        string faveString = Console.ReadLine();
        float fave = float.Parse(faveString);
        return fave;
    }
    static float SquareNumber(float fave) {
        float square = fave * fave;
        return square;
    }
    static void DisplayResult(string name, float fave, float square) {
        Console.WriteLine($"{name}, {fave} squared is {square}.");
    }
}