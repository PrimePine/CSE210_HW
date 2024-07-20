using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;

namespace Final_project
{
    public partial class Character_sheet : Form
    {
        public String lastfile = "";
        public int Max_Hp = 0;
        public int Ac = 0;
        public Character_sheet()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=KOLTON-PC;Initial Catalog = Character; Integrated Security = True; Trust Server Certificate=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveandloadtojson.Character cs= new saveandloadtojson.Character();
            cs.Name = textBox1.Text;
            cs.Race = comboBox1.Text;
            cs.Class = comboBox2.Text;
            cs.Alignment = comboBox3.Text;
            cs.strength = Convert.ToInt32(numericUpDown1.Value);
            cs.dexterity = Convert.ToInt32(numericUpDown2.Value);
            cs.constitution = Convert.ToInt32(numericUpDown3.Value);
            cs.intelligence = Convert.ToInt32(numericUpDown4.Value);
            cs.wisdom = Convert.ToInt32(numericUpDown5.Value);
            cs.charisma = Convert.ToInt32(numericUpDown6.Value);
            saveandloadtojson save = new saveandloadtojson();
            save.Save(cs);
            



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.ComboBox GetComboBox2()
        {
            return comboBox2;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> inventory = new List<string>();
            List<string> spells_and_abilities = new List<string>();
            textBox4.Text = "";
            textBox5.Text = "";

            switch (comboBox2.Text)
            {
                case "Warrior":
                    inventory.Add("Chainmail");
                    inventory.Add("Shield");
                    inventory.Add("Longsword");
                    inventory.Add("Dungeoneer's Pack");
                    inventory.Add("Explorer's Pack");
                    inventory.Add("Javelin x4");
                    break;
                case "Wizard":
                    inventory.Add("Quarterstaff");
                    inventory.Add("Component Pouch");
                    inventory.Add("Scholar's Pack");
                    inventory.Add("Spellbook");
                    break;
                case "Rogue":
                    inventory.Add("Rapier");
                    inventory.Add("Shortbow");
                    inventory.Add("Quiver of 20 Arrows");
                    inventory.Add("Burglar's Pack");
                    inventory.Add("Dungeoneer's Pack");
                    inventory.Add("Leather Armor");
                    inventory.Add("Dagger x2");
                    break;
                case "Cleric":
                    inventory.Add("Mace");
                    inventory.Add("Scale Mail");
                    inventory.Add("Shield");
                    inventory.Add("Holy Symbol");
                    inventory.Add("Prayer Book");
                    inventory.Add("Explorer's Pack");
                    break;
                case "Barbarian":
                    inventory.Add("Greataxe");
                    inventory.Add("Handaxe x2");
                    inventory.Add("Explorer's Pack");
                    inventory.Add("Javelin x4");
                    inventory.Add("Javelin x4");
                    break;
                case "Sorcerer":
                    inventory.Add("Dagger");
                    inventory.Add("Component Pouch");
                    inventory.Add("Explorer's Pack");
                    inventory.Add("Arcane Focus");
                    break;
                case "Paladin":
                    inventory.Add("Longsword");
                    inventory.Add("Shield");
                    inventory.Add("Chainmail");
                    inventory.Add("Holy Symbol");
                    inventory.Add("Explorer's Pack");
                    break;
                case "Ranger":
                    inventory.Add("Scale Mail");
                    inventory.Add("Shortsword");
                    inventory.Add("Shortbow");
                    inventory.Add("Quiver of 20 Arrows");
                    inventory.Add("Explorer's Pack");
                    break;
                default:
                    break;

            }
            foreach (string item in inventory)
            {
                textBox4.Text += item + "\r\n";
            }
            switch(comboBox2.Text)
            {
                case "Warrior":
                    spells_and_abilities.Add("Action Surge");
                    spells_and_abilities.Add("Second Wind");
                    spells_and_abilities.Add("Extra Attack");
                    break;
                case "Wizard":
                    spells_and_abilities.Add("Mage Hand");
                    spells_and_abilities.Add("Fireball");
                    spells_and_abilities.Add("Magic Missile");
                    break;
                case "Rogue":
                    spells_and_abilities.Add("Sneak attack");
                    spells_and_abilities.Add("Thieves' Cant");
                    spells_and_abilities.Add("Cunning Action");
                    break;
                case "Cleric":
                    spells_and_abilities.Add("Guidance");
                    spells_and_abilities.Add("Light");
                    spells_and_abilities.Add("Mending");
                    break;
                case "Barbarian":
                    spells_and_abilities.Add("Rage");
                    spells_and_abilities.Add("Unarmored Defense");
                    spells_and_abilities.Add("Reckless Attack");
                    break;
                case "Sorcerer":
                    spells_and_abilities.Add("Fire bolt");
                    spells_and_abilities.Add("Mage Armor");
                    spells_and_abilities.Add("Magic Missile");
                    break;
                case "Paladin":
                    spells_and_abilities.Add("Smite");
                    spells_and_abilities.Add("Bless");
                    spells_and_abilities.Add("Cure Wounds");
                    break;
                case "Ranger":
                    spells_and_abilities.Add("Spell casting");
                    spells_and_abilities.Add("Hunter's Mark");
                    spells_and_abilities.Add("Primeval Awareness");
                    break;
                default:
                    break;
            }
            foreach (string item in spells_and_abilities)
            {
                textBox5.Text += item + "\r\n";
            }



        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Warrior")
            {
                Max_Hp = 10 + Convert.ToInt32((numericUpDown3.Value - 10) / 2);
            }
            else if (comboBox2.Text == "Paladin")
            {
                Max_Hp = 10 + Convert.ToInt32((numericUpDown3.Value - 10) / 2);
            }
            else if (comboBox2.Text == "Ranger")
            {
                Max_Hp = 10 + Convert.ToInt32((numericUpDown3.Value - 10) / 2);
            }
            else if (comboBox2.Text == "Barbarian")
            {
                Max_Hp = 12 + Convert.ToInt32((numericUpDown3.Value - 10) / 2);
            }
            else if (comboBox2.Text == "Rogue")
            {
                Max_Hp = 8 + Convert.ToInt32((numericUpDown3.Value - 10) / 2);
            }
            else if (comboBox2.Text == "Cleric")
            {
                Max_Hp = 8 + Convert.ToInt32((numericUpDown3.Value - 10) / 2);
            }
            else if (comboBox2.Text == "Sorcerer")
            {
                Max_Hp = 8 + Convert.ToInt32((numericUpDown3.Value - 10) / 2);
            }
            else if (comboBox2.Text == "Wizard")
            {
                Max_Hp = 6 + Convert.ToInt32((numericUpDown3.Value - 10) / 2);
            }
            textBox2.Text = Max_Hp.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Ac = 10 + Convert.ToInt32((numericUpDown2.Value - 10) / 2);
            textBox3.Text = Ac.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
