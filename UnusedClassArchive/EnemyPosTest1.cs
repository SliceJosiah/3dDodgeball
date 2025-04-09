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
    public partial class EnemyPosTest1 : Form
    {
        Enemies1 enemies1 = new Enemies1();
        public EnemyPosTest1()
        {
            InitializeComponent();
            //enemies1.enemyPosLine = 350;    //how many pixels down is enemy position line
            //enemies1.enemyPosMax = 5;   //length of the max width enemies can travel in metres
            //enemies1.enemyCount = 5;
            
        }

        private void btnRegenerate_Click(object sender, EventArgs e)
        {
            lstEnemyPos.Items.Clear();
            lstEnemyPWidth.Items.Clear();
            enemies1.enemyGen();
            for (int i = 0; i < 5; i++)
            {
                lstEnemyPos.Items.Add(enemies1.enemyPos[i].ToString());
                lstEnemyPWidth.Items.Add(((enemies1.enemyPos[i]) + (enemies1.enemyWidth[i])).ToString());
            }
        }
    }
}
