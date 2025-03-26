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
    public partial class Settings1 : Form
    {
        //change numer of enemies
        public double enemyCount { get; set; } = 5; //enemycount is a public double that can be accessed from other classes, starts off as 5 (default)
        public Settings1()
        {
            InitializeComponent();
        }

        private void txtEnemyCount_TextChanged(object sender, EventArgs e)
        {
            double txtEnemy = System.Convert.ToInt32(txtEnemyCount.Text);
            if (txtEnemy > 10)
            {

            }
        }
    }
}
