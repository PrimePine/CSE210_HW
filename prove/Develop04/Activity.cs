using System;
using System.Collections.Generic;
using System.Diagnostics;

class Activity
{
    //attributes
    protected string _name;
    protected int _duration;

    protected string _message = "you may begin in...";

    public Activity(string nameparam, int durationparam)
    {
        _name = nameparam;
        _duration = durationparam;
    }
   public void Dispayactivity(){
        Console.WriteLine($"Welcom to the {_name} activity");
   }
   public int GetDuration(){
        Console.WriteLine("Who long would you like to do this activity?");
         _duration = Convert.ToInt32(Console.ReadLine());
        return _duration;
   }
   public void Getready(){
    //spinner animation
    Console.WriteLine();
    Spinner spinner= new Spinner();
    spinner.ShowSpinnerReady();

   }
    public void GetDone()
    {
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerDone();
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity!");
        spinner.ShowSpinner();
    }
   public void Countdown(int time){
         for(int i = time; i>0; i--){
              Console.WriteLine($"{_message} {i}");
              System.Threading.Thread.Sleep(1000);
         }
         Console.WriteLine("Begin");
   }


}