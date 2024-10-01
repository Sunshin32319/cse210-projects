using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // first function
        DisplayWelcomeMessage();

        // Declare userName variable and call function
        string userName = promptUserName();

        // DisplayResult();
    }
    // DisplayWelcomeMessage function body
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    // PromptUserName function
    static string promptUserName()
    {
        // prompt user name
        Console.WriteLine("What is your name? ");
        
        // write user name
    }
}