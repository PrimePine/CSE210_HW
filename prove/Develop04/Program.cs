using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the midfulness app!");
        int menu = 0;
        int seconds = 0;
        while(menu!=4){
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Listing activity)");
            Console.WriteLine("3. Reflecting activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose activity: ");
            menu = Convert.ToInt32(Console.ReadLine());
            switch(menu){
                case 1:
                //Breathing activity
                    BreathingAct breathing = new BreathingAct("Breathing", 0);
                    breathing.Dispayactivity();
                    breathing.GetDescription();
                    seconds=breathing.GetDuration();
                    breathing.Getready();
                    breathing.breating(seconds);
                    breathing.GetDone();
                    break;
                case 2:
                    //Listing activity
                    ListingAct listing = new ListingAct("Listing", 0);
                    listing.Dispayactivity();
                    listing.GetDescription();
                    seconds=listing.GetDuration();
                    listing.Getready();
                    listing.Listing(seconds);
                    listing.GetDone();
                    break;
                case 3:
                    //Reflecting activity
                    ReflectingAct reflecting = new ReflectingAct("Reflecting", 0);
                    reflecting.Dispayactivity();
                    reflecting.GetDescription();
                    seconds=reflecting.GetDuration();
                    reflecting.Getready();
                    reflecting.ShowPrompt(seconds);
                    reflecting.GetDone();
                    break;
                case 4:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
        }

    }
}
}