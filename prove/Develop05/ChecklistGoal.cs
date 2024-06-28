using System;

public class ChecklistGoal:Goal{
    private int _reachbonus;
    private int _bonuspoints;
    public ChecklistGoal():base(){
        this._reachbonus = SetReachBonus();
        this._bonuspoints = SetBonusPoints();
    }
    public ChecklistGoal(string name, string description, int points,int timesCompleted, int reachbonus, int bonuspoints):base(name, description, points, timesCompleted){
        this._reachbonus=reachbonus;
        this._bonuspoints=bonuspoints;

    }
    protected int SetReachBonus()
    {
        Console.WriteLine("What is the reach bonus?");
        return int.Parse(Console.ReadLine());
    }
    protected int SetBonusPoints()
    {
        Console.WriteLine("What is the bonus points?");
        return int.Parse(Console.ReadLine());
    }
    public override int GetReachBonus(){
        return this._reachbonus;
    }
    public override int GetBonusPoints(){
        return this._bonuspoints;
    }

    public override void ListGoal() {
        base.ListGoal();
        Console.Write($" --- Currently completed: {this._timesCompleted}/{this._reachbonus}\n");
    }
    public override bool IsComplete(){
        if(this._timesCompleted >= this._reachbonus){
            return true;
        }
        else {
            return false;
        }
    }
    public override double RecordEvent(){
        base.RecordEvent();
        if(IsComplete()){
            return AwardPoints(this._bonuspoints + this._points);
        }
        else {
            return AwardPoints(this._points);
        }
    }
    public override string SerializeSelf(){
        this._formattedString = "checklist";
        base.SerializeSelf();
        this._formattedString += $":{this.GetReachBonus()}:{this.GetBonusPoints()}";
        return this._formattedString;
    }


}