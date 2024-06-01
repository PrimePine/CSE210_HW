using System;
using System.Security.Cryptography.X509Certificates;

class Scripture{
    private List<Word> _words;
    private Reference Reference{get;}
    private int currentwordindex=0;
    public Scripture(Reference reference,string scripture){
        Reference=reference;
        _words=new List<Word>();
        string[] wordArray=scripture.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }

        

    }
     public void HideRandom()
    {
        if (currentwordindex < _words.Count)
        {
            List<int> hiddenIndexes = _words
                .Select((word, index) => new { Word = word, Index = index })
                .Where(item => !item.Word.Ishidden)
                .Select(item => item.Index)
                .ToList();

            if (hiddenIndexes.Count > 0)
            {
                Random random = new Random();
                for (int i=0;i<3;i++){
                int randomIndex = random.Next(0, hiddenIndexes.Count);
                _words[hiddenIndexes[randomIndex]].Hide();
                currentwordindex++;
                }
            }

        }
    }

    public bool IsCompletelyHidden()
    {
        return currentwordindex >= _words.Count;
    }
    public string RenderScripture()
    {
        List<string> visibleWords = _words.ConvertAll(word => word.ToString());
        string renderedText = string.Join(" ", visibleWords);
        return renderedText;

    
}
}


