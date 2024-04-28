using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter Your grade percentage: ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        string Letter = "";
        if (percent >= 90)
        {
            Letter = "A";
        }
        else if (percent >=80)
        {
            Letter = "B";
        }
        else if (percent >=70)
        {
            Letter = "C";
        }
        else if (percent >=60)
        {
            Letter ="D";
        }
        else
        {
            Letter = "F";
        }
        Console.WriteLine($"Your letter grade is {Letter}");
        if (percent >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
        


    }   
}