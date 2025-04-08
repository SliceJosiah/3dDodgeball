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
        GameUpd1 gameUpd1 = new GameUpd1(); //define gameUpd1 for timer
        Player1 player1 = new Player1();    //define player1 for input
        public Game2()
        {
            InitializeComponent();
            
            this.DoubleBuffered = true; //double buffer reduce flicker
            // Enemies1 enemies1 = new Enemies1();
            // enemies1.enemyPosLine = 350;    //how many pixels down is enemy position line
            // enemies1.enemyPosMax = 5;   //length of the max width enemies can travel in metres
            // enemies1.enemyCount = 5;
            this.KeyDown += player1.inputKey;
            this.KeyUp += player1.inputKeyUp;

            System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();    //make timer
            updateTimer.Interval = 10;    //update every 10 ms (must be nice number for proper physics
            updateTimer.Tick += gameUpd1.gameTimer;   //run gameTimer (in GameUpd) for each timer tick
            updateTimer.Start();
        }
    }
}
