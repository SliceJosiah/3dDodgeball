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
    public partial class VertThrowTester : Form
    {
        double ballX;
        double ballY;
        double maxDist1 = 10;
        double ballVelX;
        double ballVelY;
        double ballStartX;
        Random random = new Random(Guid.NewGuid().GetHashCode());   //found this code on stackoverflow for a decent random seed generator, uses the hash code for a new guid integer as a seed
        
        public VertThrowTester()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            ballX = 0;
            ballY = 2;
            ballVelX = Math.Sqrt((2 * -9.8 * -1) / (Math.Pow(-0.5, 2) - 1));
            ballVelY = 2;
            System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();    //make timer
            updateTimer.Interval = 10;    //update every 10 ms (must be nice number for proper physics
            updateTimer.Tick += testTimer;   //run gameTimer (in GameUpd) for each timer tick
            updateTimer.Start();
        }

        public void testTimer(object sender, EventArgs e)
        {
            
        }
    }
}
