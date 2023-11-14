using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class InGameSettingsPage : Form
    {
       
        public InGameSettingsPage()
        {
            InitializeComponent();
        
        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {   
            this.Hide();
        }

        private void btnControls_Click(object sender, EventArgs e)
        {
            InGameControlsPage inGameControlsPage = new InGameControlsPage();
            inGameControlsPage.Show();
            this.Hide();
        }

        private bool isVolumeMuted = false;

        private void ToggleVolume()
        {
            var controller = new CoreAudioController();
            var defaultPlaybackDevice = controller.DefaultPlaybackDevice;


            if (isVolumeMuted)
            {
                defaultPlaybackDevice.Mute(false);
            }
            else
            {
                defaultPlaybackDevice.Mute(true);
            }
            isVolumeMuted = !isVolumeMuted;
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            ToggleVolume();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
         
        }
    }
}
