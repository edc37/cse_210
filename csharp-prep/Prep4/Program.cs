using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Please enter a number (0 when finished): ");
        string numString = Console.ReadLine();
        int num = int.Parse(numString);
        if (num != 0) {
            numbers.Add(num);
        }
        while (num != 0) {
            Console.WriteLine("Another: ");
            string another = Console.ReadLine();
            num = int.Parse(another);
            if (num != 0) {
                numbers.Add(num);
            }
        }

        //variables
        float total = 0;        
        int largest = 0;

        foreach (int number in numbers) {
            //sum list
            total += number;    

            // largest
            if (number > largest) {
                largest = number;
            }
        }

        // avgerage
        int length = numbers.Count;
        float avg = total / length;
        
        Console.WriteLine(length);
        Console.WriteLine($"The total is {total}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The largest number is {largest}");
    }
}