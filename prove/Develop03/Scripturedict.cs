using System;
using System.Data;
using System.Collections.Generic;
class ScriptureLibrary{
    private List<Scripture> _scriptures = new List<Scripture>();
    public ScriptureLibrary(){
        _scriptures=new List<Scripture>();
    }
    public void AddScripture(Reference reference, string text){
        _scriptures.Add(new Scripture(reference,text));
    }
    public Scripture GetRandomScripture(){
        Random random=new Random();
        int randomIndex=random.Next(0,_scriptures.Count);
        return _scriptures[randomIndex];
    }
}