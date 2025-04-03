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
        double ballStartY;
        double ballThrowSpeed;
        double ballThrowAngle;
        double gravAccel = -9.8;
        double ballDiameter = 0.3;
        double playerHeight = 2;
        double testnum = 0;
        Random random = new Random(Guid.NewGuid().GetHashCode());   //found this code on stackoverflow for a decent random seed generator, uses the hash code for a new guid integer as a seed
        
        public VertThrowTester()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += drawBall;
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            ballY = 0;
            ballX = 2;
            ballThrowAngle = 30;
            ballThrowSpeed = 10;
            ballVelY = ballThrowSpeed * Math.Sin(ballThrowAngle);
            ballVelX = ballThrowSpeed * Math.Cos(ballThrowAngle);
            
            System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();    //make timer
            updateTimer.Interval = 1000;    //update every 10 ms (must be nice number for proper physics
            updateTimer.Tick += testTimer;   //run gameTimer (in GameUpd) for each timer tick
            updateTimer.Start();
        }

        public void testTimer(object sender, EventArgs e)
        {
            //testnum++;
            //btnThrow.Text = Convert.ToString(testnum);

            //if (ballY <= 0) return;

            ballVelY += gravAccel / 100;
            ballY += ballVelY / 100;
            ballX += ballVelX / 100;

            lblX.Text = ballX.ToString();
            lblY.Text = ballY.ToString();

            this.Invalidate();
        }

        public void drawBall(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            e.Graphics.FillRectangle(Brushes.Aqua, Convert.ToSingle(ballX), 10, 10, 10);
            e.Graphics.FillEllipse(Brushes.Red, Convert.ToSingle(ballX - ballDiameter * 0.5 * 100), Convert.ToSingle((ballY - ballDiameter * 0.5) * -100 + this.ClientSize.Height), Convert.ToSingle(ballDiameter) * 100, Convert.ToSingle(ballDiameter) * 100);
        }
    }
}
