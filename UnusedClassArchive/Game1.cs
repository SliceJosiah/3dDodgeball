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
    public partial class Game1 : Form
    {
        
        //Graphics g;
        //const double fpointx = 500; //focal point
        //const double fpointy = 350;
        //double ppointx = fpointx;   //player point (view is based off this)
        //double ppointy = fpointy;

        public Game1()
        {
            //InitializeComponent();
            //this.ClientSize = new Size(1000, 700);   //form must be 1000/700
            //this.DoubleBuffered = true; //double buffer reduce flicker
            //this.Paint += DrawGame; //render game
            //this.KeyDown += HandleInput;    //handle inupt
            //this.KeyUp += HandleKeyUp;  //handle input end

            ////game timer
            //System.Windows.Forms.Timer gameTimer = new
            //    System.Windows.Forms.Timer();   //use windows forms' timer
            //gameTimer.Interval = 10;    //update every 10 ms (must be nice number for proper physics
            //gameTimer.Tick += UpdateGame;   //update logic??
            //gameTimer.Start();
        }

        private void Game1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateGame (object sender, EventArgs e)
        {
            

        }
    }
}
