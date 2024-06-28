using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    protected bool _isComplete;
    protected int _timesCompleted;

    protected string _formattedString = "";

    public Goal()
    {
        this._name = SetName();
        this._description = SetDescription();
        this._points = SetPoints();
        this._timesCompleted = 0;
    }

    public Goal(string name, string description, int points, int timesCompleted)
    {
        this._name = name;
        this._description = description;
        this._points = points;
        this._timesCompleted = timesCompleted;
    }

    protected string SetName()
    {
        Console.WriteLine("What is the name of the goal?");
        return Console.ReadLine();
    }
    protected string SetDescription()
    {
        Console.WriteLine("What is the description of the goal?");
        return Console.ReadLine();
    }

    protected int SetPoints()
    {
        Console.WriteLine("How many points is the goal worth?");
        return int.Parse(Console.ReadLine());
    }
    public string GetName(){
        return this._name;
    }
    public string GetDescription(){
        return this._description;
    }
    public double GetPoints(){
        return this._points;
    }
    public double GetTimesFinished(){
        return this._timesCompleted;
    }
    public virtual int GetReachBonus(){
        return 0;
    }
    public virtual int GetBonusPoints(){
        return 0;
    }

    public double AwardPoints(double points){
        Console.WriteLine($"Congratualations! You have earned {this._points} points!\n");
        return points;
    }

    public virtual double RecordEvent(){
        this._timesCompleted += 1;
        return 0;
    }

    public abstract bool IsComplete();

     public virtual void ListGoal(){
        if(IsComplete()){
            Console.Write($" [X] {this._name} ({this._description})");
        }
        if(!IsComplete()){
            Console.Write($" [ ] {this._name} ({this._description})");
        }
    }

    public virtual string SerializeSelf(){
        this._formattedString += $":{this.GetName()}"
                                +$":{this.GetDescription()}:{this.GetPoints()}"
                                +$":{this.GetTimesFinished()}";
        return this._formattedString;
    }
}






