/*Created by Jakub Wichliński github.com/kubawich

Name generator is 1st out of 100 apps made with contest training app list (tnij.org/trainingapps)

TODO: 
Fix multiplication of predefinied list values
Let program draw all name/surname values into listView
Add working progress bar
Refactoring & comments
Improve design and UX(maybe rewrite to wpf using material design template)*/

using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace NameGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGenerate(object sender, EventArgs e)
        {
            SystemSound genSound = SystemSounds.Beep;
            lblWynik.Text = Generate.NameGen() + " " + Generate.SurnameGen();
            genSound.Play();
            Console.WriteLine("Generating: " + lblWynik.Text);
        }

        private void AddName(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameBox.Text.ToString()))
                MessageBox.Show("Error: field cannot be empty");
            else {
                Generate.LName.Add(NameBox.Text.ToString());
                Console.WriteLine("Adding new name to index: " + NameBox.Text);
                Generate.LName.ForEach(item => Console.WriteLine(item));
                NameBox.Clear();
            }
        }

        private void AddSurname(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SurnameBox.Text.ToString()))
                MessageBox.Show("Error: field cannot be empty");
            else {
                Generate.LName.Add(SurnameBox.Text.ToString());
                Console.WriteLine("Adding new name to index: " + SurnameBox.Text);
                Generate.LSurname.ForEach(item => Console.WriteLine(item));
                SurnameBox.Clear();
            }
        }
    }

    public class Generate
    {
        static string[] Name = { "Mariusz", "Janusz", "Bogdan", "Zbigniew" };
        static string[] Surname = { "Stonoga", "Wałęsa", "Białkov", "Wichliński" };

        public static List<string> LName = new List<string>();
        public static List<string> LSurname = new List<string>();

        static Random random = new Random();

        public static string NameGen()
        {
            LName.AddRange(Name);
            int NameIndex = random.Next(LName.Count);
            return LName[NameIndex];
        }

        public static string SurnameGen()
        {
            LSurname.AddRange(Surname);
            int NameIndex = random.Next(LSurname.Count);
            return LSurname[NameIndex];
        }
    }
}
