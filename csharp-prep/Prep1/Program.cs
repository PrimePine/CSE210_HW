using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your First Name: ");
        string first = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string Last = Console.ReadLine();
        Console.WriteLine($"Your name is {Last}, {first} {Last}.");
    }
}