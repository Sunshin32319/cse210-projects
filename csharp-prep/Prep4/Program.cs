using System;
using System.Collections.Generic;

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
        } while (userNumber != 0);
    }
}