using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.AddScripture(new Reference("John", 3, 16), "For God so loved the world...");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart...");
        library.AddScripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd, I shall not want.");
        library.AddScripture(new Reference("Isaiah", 40, 31), "But those who hope in the Lord will renew their strength.");
        library.AddScripture(new Reference("Matthew", 11, 28), "Come to me, all you who are weary and burdened, and I will give you rest.");
        library.AddScripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me.");

        Console.WriteLine("This is a scripture memorizer program.");
        Console.WriteLine("Ress 1 to enter a new scripture, press 2 to enter the memorizor or type quit to quit: ");
        string input = Console.ReadLine();
        while(true){

        
        if (input == "1")
        {
            Console.WriteLine("Enter the book name: ");
            string book = Console.ReadLine();
            Console.WriteLine("Enter the chapter number: ");
            int chapter = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the verse number: ");
            int verse = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the verse: ");
            string verseText = Console.ReadLine();
            library.AddScripture(new Reference(book, chapter, verse), verseText);
        }
        else if (input == "2"){
            Console.Clear();
            Scripture scripture = library.GetRandomScripture();

            if (scripture != null)
            {
                bool memorized = false;

                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.RenderScripture());

                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string Input = Console.ReadLine();

                    if (Input.ToLower() == "quit")
                        return;

                    scripture.HideRandom();

                    if (scripture.IsCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.WriteLine("You've memorized the entire scripture!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures or load them from files.");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
  }  
}