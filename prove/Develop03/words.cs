using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

class Word{
    public string Text{get;}
    public bool Ishidden{get; private set;}
    public Word(string text){
        Text=text;
        Ishidden=false;

    }
    public void Hide(){
        Ishidden=true;
    }
    public void Reveal(){
        Ishidden=false;
    }
    public override string ToString()
    {
        return Ishidden ? new string('_', Text.Length) : Text;
    }
    
}
