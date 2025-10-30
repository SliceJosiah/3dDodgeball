using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class GameUpd1
    {
        private Player1 player1;
        private Enemies1 enemies1;
        //Settings1 settings1 = new Settings1();
        //Game2 game2 = new Game2();
        private Game2 game2;    //define existing instance of game2
        public static double courtWidth = 5;
        public static double courtLength = 10;
        public static int enemyCount = 5;
        public string uname;
        public GameUpd1(Player1 player1a, Enemies1 enemies1a, Game2 game2a, string usernamea)
        {
            game2 = game2a; //set variable
            player1 = player1a; //set variable
            enemies1 = enemies1a;
            enemies1.enemyGen();
            uname = usernamea;
            //enemies1.enemyPosLine = 350;    //how many pixels down is enemy position line
            //enemies1.enemyPosMax = 5;   //length of the max width enemies can travel in metres
        }

        public void gameTimer(object sender, EventArgs e)
        {
            if (player1.playerStatus != 4)
            {
                player1.updatePlayer();
                enemies1.updateEnemy();
                game2.Invalidate();
                /*game2.lblPlayerPos.Text = player1.playerPos.ToString();
                game2.lblPlayerMultPos.Text = player1.playerSpeedMult.ToString();
                game2.lblKeyTogDir.Text = player1.playerMove.ToString();
                game2.lblRKeyDown.Text = player1.keyDown[2].ToString();*/
            }
            else
            {
                game2.Visible = false;
                ScoresList1 scoresList1 = new ScoresList1(uname, Convert.ToInt32(player1.points));
                scoresList1.Show();
                (sender as System.Windows.Forms.Timer)?.Stop();
            }
        }
    }
}
