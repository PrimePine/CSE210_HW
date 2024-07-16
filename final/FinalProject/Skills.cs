using System;
using System.Diagnostics;
using System.Collections.Generic;

class Skills{
   List<string> _Skills;
    string skills;
    public Skills(){
         this._Skills = SetSkills();
    }

    protected List<string> SetSkills(){
        Console.WriteLine("Enter the skills of your character. Enter 'done' when finished.");
        while (skills != "done"){
            List<string> _Skills = new List<string>();
            skills = Console.ReadLine();
            _Skills.Add(Console.ReadLine());
        }
        return _Skills;
    }
    public void Displayskills(){
        foreach (string skill in _Skills){
            Console.WriteLine(skill);
        }
    }

}