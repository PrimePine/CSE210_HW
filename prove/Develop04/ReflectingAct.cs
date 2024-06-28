using System;
using System.Diagnostics;

class ReflectingAct : Activity{
    private List<string> _Prompts= new List<string>
    {
        "Thnking about the past week, what are some things that went well?",
        "Thinking about the past week, what are some things that didn't go well?",
        "What are some things you would like to improve on?",
        "What are some things you would like to accomplish in the future?",
        "What are some things you are looking forward to?",
    };
    private List<string> _Questions= new List<string>
    {
        "Why do you think this?",
        "How do you feel about this?",
        "What can you do to improve this?",
        "What are some steps you can take to accomplish this?",
        "What are some things you can do to prepare for this?",

    };
    private List<string> _usequestionlist= new List<string>();
    private string _prompt;
    private string _description = "this activity is designed to help you focus on your thoughts and feelings";

    public ReflectingAct(string nameparam, int durationparam) : base(nameparam, durationparam)
    {

    }
    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_Prompts.Count);
        return _Prompts[index];
    }
    private string GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_Questions.Count);
        return _Questions[index];
    }
    public void GetDescription()
    {
        Console.WriteLine(_description);
    }
    public void ShowPrompt(int seconds){
        Console.WriteLine();
        Console.WriteLine("Think about the following prompt:");
        _prompt = GetRandomPrompt();
        Console.WriteLine(_prompt);
        Console.WriteLine("When you are ready, press enter to continue");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter){
            Showquestion(seconds);
        }
    }
    public void Showquestion(int seconds){
        _usequestionlist.AddRange(_Questions);
        Console.WriteLine();
        Console.WriteLine("Think about the following questions as they appear:");
        Countdown(8);
        Console.WriteLine();
        Stopwatch Time = new Stopwatch();
        Time.Start();
        while(Time.Elapsed.Seconds<seconds){
            if (_usequestionlist.Count != 0){
                var question = GetRandomQuestion();
                Console.WriteLine(question);
                _usequestionlist.Remove(question);
           
            }

        }
        Time.Stop();
    }

}