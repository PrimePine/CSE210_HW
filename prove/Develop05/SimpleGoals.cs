using System;

public class SimpleGoals : Goal{
    public SimpleGoals():base(){

    }
    public SimpleGoals(string name, string description, int points, int timesCompleted):base(name, description, points, timesCompleted){

    }
    public override bool IsComplete()
    {
        if(this._timesCompleted >= 1){
            return true;
        }
        else{
            return false;
        }
    }
    public override double RecordEvent()
    {
        base.RecordEvent();
        return AwardPoints(this._points);
    }
    public override string SerializeSelf()
    {
        this._formattedString="simple";
        return base.SerializeSelf();
    }
    public override void ListGoal(){
        base.ListGoal();
        Console.WriteLine("----simple goal\n");
    }
}