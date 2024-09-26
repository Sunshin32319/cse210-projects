using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string letter = "";
        int lastDigit = number % 10;
        string sign = "";


        if (number >= 90)
        {
            letter = "A";
            if (number >= 93)
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else if (number >= 80)
        {
            letter = "B";
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (number >= 70)
        {
            letter = "C";
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (number >= 60)
        {
            letter = "D";
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else
        {
            letter = "F";
            sign = "";
        }
        Console.WriteLine($"Your grade is {letter}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("Congradulations! You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass. Try again next time.");
        }

    }
}