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
        public GameUpd1(Player1 player1a, Enemies1 enemies1a, Game2 game2a)
        {
            game2 = game2a; //set variable
            player1 = player1a; //set variable
            enemies1 = enemies1a;
            enemies1.enemyGen();
            //enemies1.enemyPosLine = 350;    //how many pixels down is enemy position line
            //enemies1.enemyPosMax = 5;   //length of the max width enemies can travel in metres
        }

        public void gameTimer(object sender, EventArgs e)
        {
            player1.updatePlayer();
            enemies1.updateEnemy();
            game2.Invalidate();
        }
    }
}
