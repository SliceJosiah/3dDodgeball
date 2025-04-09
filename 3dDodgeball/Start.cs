using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3dDodgeball
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("you have to enter a username to play :3");
                return;
            }
            this.Visible = false;
            Game2 game2 = new Game2(username);
            game2.Show();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtName.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("username must be less than 12 characters :3");
            }
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("usernames can only have letters and numbers :3");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string username = "testerman";
            int points = 69420;
            this.Visible = false;
            Game2 game2 = new Game2(username);
            game2.Show();
        }
    }
}
