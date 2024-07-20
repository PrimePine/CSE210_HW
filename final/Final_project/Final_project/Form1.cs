using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Character_sheet cs = new Character_sheet();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "CharacterSheet.json";
            string jsonString = File.ReadAllText(fileName);
            Character_sheet character = JsonSerializer.Deserialize<Character_sheet>(jsonString);
            character.Show();
        }

    }
}
