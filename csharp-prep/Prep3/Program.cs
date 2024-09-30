using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 1;
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        while (answer != guess)
        {
            Console.WriteLine("Guess a number! What is the number? ");

            if (answer < guess)
            {
                Console.WriteLine("Lower!");
            }
            else if (answer > guess)
            {
                Console.WriteLine("Higher!");
            }
            else if (answer == guess)
            {
                Console.WriteLine("You guessed it! Great job!");
                break;
            }
            else
            {
                Console.WriteLine("Uh oh! Something's not right. Try again later.");
                break;
            }
        }
    }
}