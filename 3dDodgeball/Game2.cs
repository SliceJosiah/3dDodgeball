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
    public partial class Game2 : Form
    {
        public Game2()
        {
            InitializeComponent();
            Enemies1 enemies1 = new Enemies1();
            enemies1.enemyPosLine = 350;    //how many pixels down is enemy position line
            enemies1.enemyPosMax = 5;   //length of the max width enemies can travel in metres
            enemies1.enemyCount = 5;
        }

        private void Game2_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
