using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_project
{
    public class saveandloadtojson
    {
        string Name;
        string Race;
        string Class;
        string Alignment;
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;

        public class Character
        {
            public string Name { get; set; }
            public string Race { get; set; }
            public string Class { get; set; }
            public string Alignment { get; set; }
            public int strength { get; set; }
            public int dexterity { get; set; }
            public int constitution { get; set; }
            public int intelligence { get; set; }
            public int wisdom { get; set; }
            public int charisma { get; set; }


        }
        public void Save(Character character)
        {

            string jsonString = JsonSerializer.Serialize(character);
            File.WriteAllText("CharacterSheet.json", jsonString);
        }
    }
}
