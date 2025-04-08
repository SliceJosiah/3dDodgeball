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
        Enemies1 enemies1 = new Enemies1();
        Settings1 settings1 = new Settings1();
        //Game2 game2 = new Game2();
        private Game2 game2;    //define existing instance of game2
        public double courtWidth;
        public double courtLength;
        public GameUpd1()
        {
            enemies1.enemyGen();
            enemies1.enemyPosLine = 350;    //how many pixels down is enemy position line
            enemies1.enemyPosMax = 5;   //length of the max width enemies can travel in metres
            enemies1.enemyCount = 5;
        }

        public void gameTimer(object sender, EventArgs e)
        {
            
        }
    }
}
