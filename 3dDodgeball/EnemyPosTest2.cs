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
    public partial class EnemyPosTest2 : Form
    {
        Enemies1 enemies1 = new Enemies1();
        bool a = false;
        public EnemyPosTest2()
        {
            InitializeComponent();
            enemies1.enemyPosLine = 350;    //how many pixels down is enemy position line
            enemies1.enemyPosMax = 5;   //length of the max width enemies can travel in metres
            enemies1.enemyCount = 5;
            enemies1.enemyGen();
            this.DoubleBuffered = true;
            this.Paint += drawBall;
        }

        public void drawBall(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            btnRegen.Text = enemies1.enemyPos[0].ToString();
            for (int i = 0; i < 5; i++)
            {
                e.Graphics.FillRectangle(Brushes.Black, Convert.ToSingle(enemies1.enemyPos[i] * 100), 250, Convert.ToSingle(enemies1.enemyWidth[i] * 100), Convert.ToSingle(enemies1.enemyHeight[i] * 100));
            }
        }

        private void btnRegen_Click(object sender, EventArgs e)
        {
            enemies1.enemyGen();
            this.Invalidate();
        }
    }
}
