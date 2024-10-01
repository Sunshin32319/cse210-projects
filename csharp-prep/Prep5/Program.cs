using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // first function
        DisplayWelcomeMessage();

        // Declare userName variable and call function
        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        // DisplayResult();
        DisplayResult(userName,squaredNumber);
    }
    // DisplayWelcomeMessage function body
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    // PromptUserName function
    static string PromptUserName()
    {
        // prompt user name
        Console.Write("What is your name? ");
        // store user name in variable
        string userName = Console.ReadLine();

        // return a value for this function or I get compiler error
        return (userName);
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userInputNum = Console.ReadLine();
        int userNumber = int.Parse(userInputNum);

        return(userNumber);
    }

    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return (square);
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, your number squared is {square}!");
    }
}