using System;
using System.Collections.Generic;
// This next one allows me to use the myList function
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Define User Number and create list
        // commented out for error o line 19 userNumber;
        List<int>numbers = new List<int>();
        int userNumber;

        // print instructions
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // get user input and start the loop
        do{
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            int count = 0;

            // only add the number to our list if number is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                count++;
            }
        } while (userNumber != 0);
        // Console.WriteLine($"You entered {count} numbers.");

        // Console.WriteLine($"Loop counter: {count}.");
        // Part 1, compute the sum of numbers in list
        int sumTotal = numbers.Sum();
        Console.WriteLine($"The sum is: {sumTotal}");

        // Part 2, compute the average of the numbers in list
        // average = sum of values / number of values
        // Console.WriteLine($"Loop counter: {count}.");
        float average = ((float)sumTotal) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3 - find the max number in the list
        // declare the variable
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}