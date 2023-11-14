using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.data
{
    public partial class CharacterSelection : Form
    {
        public CharacterSelection()
        {
            InitializeComponent();
        }

        private void mrpeanut_Click(object sender, EventArgs e)
        {
            // Create FrmLevel and show it
            FrmLevel level1 = new FrmLevel("mrpeanut");
            level1.Show();
            // Whenever FrmLevel is closed, execute onFormClosed method
            // level1.FormClosed += level1.OnFormClosed;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create MainMenu and show it
            MainMenu frm = new MainMenu();
            frm.Show();
            // Whenever Level is closed, execute onFormClosed method
            // frm.FormClosed += frm.OnFormClosed;
            Hide();
        }

        private void babynut_Click(object sender, EventArgs e)
        {
            // Create FrmLevel and show it
            FrmLevel level1 = new FrmLevel("babynut");
            level1.Show();
            // Whenever FrmLevel is closed, execute onFormClosed method
            // level1.FormClosed += level1.OnFormClosed;
            Hide();
        }
    }
}
