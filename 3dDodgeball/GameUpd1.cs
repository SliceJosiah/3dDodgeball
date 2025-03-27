using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class GameUpd1
    {
        Player1 player1 = new Player1();
        Enemies1 enemies1 = new Enemies1();
        Physics1 physics1 = new Physics1();
        Game2 game2 = new Game2();

        enemies1.enemyPosLine = 350;    //how many pixels down is enemy position line
        enemies1.enemyPosMax = 5;   //length of the max width enemies can travel in metres
        enemies1.enemyCount = 5;

        private void gameInit()
        {
            enemies1.enemyGen()
        }

        private void gameTimer()
        {
            
        }
    }
}
