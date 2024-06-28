using System;

class Program
{
     public static void ListGoals(List<Goal> Goals){
        Console.WriteLine("The goals are:");
            for(int i = 0; i < Goals.Count;i++){
                Console.Write($"{i+1}.");
                Goals[i].ListGoal();
            }
    }
    static void WriteString(string value, bool newLine = false, int speed = 10){
        foreach(char character in value){
            Console.Write(character);
            Thread.Sleep(speed);
        }
        if(newLine == true){Console.Write("\n");}
    }

    public static int LevelUp(int level, double points ){
        int newLevel = level;
        switch(level){
            case 1:
            if(points >= 100){newLevel = 2;}
                break;
            case 2:
            if(points >= 300){newLevel = 3;}
                break;
            case 3:
            if(points >= 500){newLevel = 4;}
                break;
            case 4:
            if(points >= 1000){newLevel = 5;}
                break;
            case 5:
            if(points >= 1500){newLevel = 6;}
                break;
            case 6:
            if(points >= 2250){newLevel = 7;}
                break;
            case 7:
            if(points >= 3000){newLevel = 8;}
                break;
            case 8:
            if(points >= 4000){newLevel = 9;}
                break;
            case 9:
            if(points >= 5000){newLevel = 10;}
                break;
        }
        if(level != newLevel){
            WriteString($"Congratulations! You are Level {newLevel}!\n", true);
        }
        return newLevel;
    }
    static void Main(string[] args)
    {
        int input;
        List<Goal> Goals = new List<Goal>();
        double points=0;
        int level=1;
        string name="";

        while(true){
            level = LevelUp(level, points);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice:");
            input = int.Parse(Console.ReadLine());
            switch(input){
                case 1:
                    Console.WriteLine("What type of goal would you like to add?");
                    Console.WriteLine("1. Simple");
                    Console.WriteLine("2. Checklist");
                    Console.WriteLine("3. Eternal");
                    Console.WriteLine("Enter your choice:");
                    input = int.Parse(Console.ReadLine());
                    switch(input){
                        case 1:
                            Goals.Add(new SimpleGoals());
                            break;
                        case 2:
                            Goals.Add(new ChecklistGoal());
                            break;
                        case 3:
                            Goals.Add(new EternalGoal());
                            break;
                    }
                    break;
                case 2:
                    ListGoals(Goals);
                    break;
                case 3:
                    Console.WriteLine("What would you like to name the file?");
                    name = Console.ReadLine();
                    using(StreamWriter sw = new StreamWriter(name)){
                        foreach(Goal goal in Goals){
                            sw.WriteLine(goal.SerializeSelf());
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("What is the name of the file?");
                    name = Console.ReadLine();
                    using(StreamReader sr = new StreamReader(name)){
                        string line;
                        while((line = sr.ReadLine()) != null){
                            string[] parts = line.Split(":");
                            switch(parts[0]){
                                case "simple":
                                    Goals.Add(new SimpleGoals(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4])));
                                    break;
                                case "checklist":
                                    Goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                                    break;
                                case "eternal":
                                    Goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4])));
                                    break;
                            }
                        }
                    }
                    break;
                case 5:
                    ListGoals(Goals);
                    Console.WriteLine("Which goal would you like to record an event for?");
                    input = int.Parse(Console.ReadLine());
                    points += Goals[input-1].RecordEvent();
                    break;
                case 6:
                    return;
            }
            WriteString($"You have {points} points!\n", true);

        }

    }
}