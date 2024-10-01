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

        // DisplayResult();
        DisplayResult(userName);
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

    static void DisplayResult(string userName)
    {
        Console.WriteLine($"{userName}, keep up the great work!");
    }
}