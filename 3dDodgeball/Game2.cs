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
        private Player1 player1;    //define variable for player1 object
        private GameUpd1 gameupd1;  //define variable
        private Render1 render1;    //define variable
        private Enemies1 enemies1;
        public Game2(string username)
        {
            InitializeComponent();

            player1 = new Player1();    //set variable player1 to new instance of player1
            enemies1 = new Enemies1(player1);
            gameupd1 = new GameUpd1(player1, enemies1, this, username); //set variable to new instance, and pass instance of player1
            render1 = new Render1(player1, enemies1, this);    //set variable

            this.ClientSize = new Size(Convert.ToInt32(GameUpd1.courtWidth * 100), Convert.ToInt32((GameUpd1.courtLength + 3) * 100 * Math.Sqrt(0.5)));
            this.DoubleBuffered = true; //double buffer reduce flicker
            // Enemies1 enemies1 = new Enemies1();
            // enemies1.enemyPosLine = 350;    //how many pixels down is enemy position line
            // enemies1.enemyPosMax = 5;   //length of the max width enemies can travel in metres
            // enemies1.enemyCount = 5;
            this.KeyDown += player1.inputKey;
            this.KeyUp += player1.inputKeyUp;
            this.Paint += render1.RenderGraphics;

            System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();    //make timer
            updateTimer.Interval = 10;    //update every 10 ms (must be nice number for proper physics
            updateTimer.Tick += gameupd1.gameTimer;   //run gameTimer (in GameUpd) for each timer tick
            updateTimer.Start();
        }
    }
}
