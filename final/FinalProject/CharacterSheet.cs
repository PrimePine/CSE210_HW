using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

class CharacterSheet{
    string _Name;
    string _Class;
    string _Race;
    string _Alignment;
    int _Strength;
    int _Dexterity;
    int _Constitution;
    int _Intelligence;
    int _Wisdom;
    int _Charisma;

    public CharacterSheet(){
        this._Name = SetName();
        this._Class = SetClass();
        this._Race = SetRace();
        this._Alignment = SetAlighnment();
        this._Strength = Setstr();
        this._Dexterity = SetDex();
        this._Constitution = SetConst();
        this._Intelligence = SetInt();
        this._Wisdom = SetWis();
        this._Charisma = SetCha();
    }
    
     protected string SetName(){
        Console.WriteLine("What is the name of your character?");
        return Console.ReadLine();
    }
    protected string SetClass(){
        Console.WriteLine("What is the class of your character?");
        return Console.ReadLine();
    }
    protected string SetRace(){
        Console.WriteLine("What is the race of your character?");
        return Console.ReadLine();
    }
    protected string SetAlighnment(){
        Console.WriteLine("What is the alignment of your character?");
        return Console.ReadLine();
    }

    protected int Setstr(){
        Console.WriteLine("What is the strength of your character?");
        return int.Parse(Console.ReadLine());
    }
    protected int SetDex(){
        Console.WriteLine("What is the dexterity of your character?");
        return int.Parse(Console.ReadLine());
    }
    protected int SetConst(){
        Console.WriteLine("What is the constitution of your character?");
        return int.Parse(Console.ReadLine());
    }
    protected int SetInt(){
        Console.WriteLine("What is the intelligence of your character?");
        return int.Parse(Console.ReadLine());
    }
    protected int SetWis(){
        Console.WriteLine("What is the wisdom of your character?");
        return int.Parse(Console.ReadLine());
    }
    protected int SetCha(){
        Console.WriteLine("What is the charisma of your character?");
        return int.Parse(Console.ReadLine());
    }

    public void Display(){
        Console.WriteLine("Name: " + _Name);
        Console.WriteLine("Class: " + _Class);
        Console.WriteLine("Race: "+ _Race);
        Console.WriteLine("Alignment: "+ _Alignment);
        Console.WriteLine("Strength: "+ _Strength);
        Console.WriteLine("Dexterity: "+ _Dexterity);
        Console.WriteLine("Constitution: "+ _Constitution);
        Console.WriteLine("Intelligence: "+ _Intelligence);
        Console.WriteLine("Wisdom: "+ _Wisdom);
        Console.WriteLine("Charisma: "+ _Charisma);
    }
    




    
}

