using System;
using System.Diagnostics;

class ListingAct : Activity
{
    private List<string> _Prompts= new List<string>
    {
        "Who are people you apeeciate in your life?",
        "What are some things you are grateful for?",
        "What are some things you are looking forward to?",
        "What are some things you are proud of?",
        "What are some things you are worried about?",
    };

    private List<string> _Responses= new List<string>();
    private string _description = "this activity is designed to help you focus on your thoughts and feelings";
    public ListingAct(string nameparam, int durationparam) : base(nameparam, durationparam)
    {

    }
    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_Prompts.Count);
        return _Prompts[index];
    }
    public void GetDescription()
    {
        Console.WriteLine(_description);
    }
    public void Listing(int seconds){
        Console.WriteLine();
        var question = GetRandomPrompt();
        Console.WriteLine("List as many things as you can think of for the following prompt: ");
        Console.WriteLine(question);
        Countdown(8);
        Time(seconds);
        
    }
    public void Time(int seconds){
        Stopwatch Time = new Stopwatch();
        Time.Start();
        while(Time.Elapsed.Seconds<seconds){
            Console.Write("> ");
            _Responses.Add(Console.ReadLine());
        }
        Time.Stop();
        int listlength = _Responses.Count;
        Console.WriteLine($"You listed {listlength} items");

    }



}