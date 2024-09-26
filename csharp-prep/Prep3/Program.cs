using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 1;
        Console.WriteLine("Guess a number! What is the number? ");
        string userGuess = Console.ReadLine();
        int userNumber = int.Parse(userGuess);

        if (answer < userNumber)
        {
            Console.WriteLine("Lower!");
        }
        else if (answer > userNumber)
        {
            Console.WriteLine("Higher!");
        }
        else if (answer == userNumber)
        {
            Console.WriteLine("You Guessed it! Congrats!");
        }
        else
        {
            Console.WriteLine("Uh oh! Something's not right. Try again later.");
        }
    }
}