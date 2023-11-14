using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.data;

namespace Fall2020_CSC403_Project
{
    public partial class Intro : Form
    {
        private List<string> lines = new List<string>
        {
            "[Mr. Peanut] What where am I...",
            "",
            "",
            "[?] Hey, you. You’re finally awake. You were trying to cross the border, right?",
            "Walked right into that Imperial ambush, same as us…",
            "",
            "",
            "[Mr. Peanut] Where are we!!",
            "",
            "",
            "[?] Soveigngaurd awaits!",
            "",
            "",
            "[Mr.Peanut] Umm sure...",
            "",
            "",
            "* Battle through these evil snack guards to reclaim your safety. *"
        };
        private int currentLineIndex = 0;
        private int displayIndex = 0;

        public Intro()
        {
            InitializeComponent();
            label1.Text = "";
            this.textTimer1.Interval = 50;
            this.textTimer1.Start();
        }

        private void textTimer1_Tick(object sender, EventArgs e)
        {
            if (currentLineIndex < lines.Count)
            {
                string currentLine = lines[currentLineIndex];

                if (displayIndex < currentLine.Length)
                {
                    label1.Text += currentLine[displayIndex];
                    displayIndex++;
                }
                else
                {
                    label1.Text += Environment.NewLine; 
                    currentLineIndex++; 
                    displayIndex = 0; 
                }
            }
            else
            {
                this.textTimer1.Stop(); 
            }
        }

        private void continue_Click(object sender, EventArgs e)
        {
            // Create FrmLevel and show it
            CharacterSelection frm = new CharacterSelection();
            frm.Show();
            // Whenever FrmLevel is closed, execute onFormClosed method
            //frm.FormClosed += frm.onFormClosed;
            Hide();
        }
    }
}
