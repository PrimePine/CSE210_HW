using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int magicnumber = randomgenerator.Next(1,101);
        int guess = -1;
        while (guess != magicnumber)
        {
            Console.Write("What is your guess");
            guess=int.Parse(Console.ReadLine());

            if (magicnumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicnumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }
    }
}