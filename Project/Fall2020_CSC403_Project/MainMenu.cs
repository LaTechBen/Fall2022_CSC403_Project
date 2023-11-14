using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Media;
using System.Windows.Forms;
using Fall2020_CSC403_Project;
using MyGameLibrary;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class MainMenu : Form
    {
        private Sound music;
        public MainMenu()
        {
            InitializeComponent();
            // initalize Sound and start the music
            // WARNING VOLUME IS LOUD
            music = new Sound();
            music.Play(Resources.CatDisk);
        }
        
        /// <summary>
        /// Method to start the game 
        /// </summary>
        private void startButtonClick(object sender, EventArgs e)
        {

            Intro intro = new Intro();
            intro.Show();
            Hide();
            music.Stop();

        }

        /// <summary>
        /// Method to handle closing game from main menu
        /// </summary>
        private void quitButtonClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            music.Stop();
            System.Windows.Forms.Application.Exit();

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            MainSettingsPage mainSettingsPage = new MainSettingsPage();
            mainSettingsPage.Show();
            this.Hide();
        }
    }
}
