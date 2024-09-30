using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int userGuess;

        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        userGuess = int.Parse(Console.ReadLine());

        if (magicNumber > userGuess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < userGuess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}