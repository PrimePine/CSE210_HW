using System;

public class Promptgenerator{public List<string> Prompts {get;set;}

   public Promptgenerator(){
    Prompts = new List<string> {
            "What was the best part of your day?",
            "Write about an experience where you felt the spirit with you today:",
            "Who was the most interesting person you interacted with today?",
            "Write about something that happened for which you are grateful today:",
            "If you had one thing you could do over today, what would it be?",
        };
   }
    public string GenerateRandomprompt(){
        Random random = new Random();
        int index =random.Next(Prompts.Count);
        return Prompts[index];
    }


}
