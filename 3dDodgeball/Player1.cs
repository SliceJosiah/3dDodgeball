using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class Player1
    {
        Game2 game2 = new Game2();

        //variables for player properties
        public double playerPos;    //player position on x axis (distance from left in m)
        public double playerMaxPos;  //maximum distance from right side (should be same as enemyMaxPos)
        public double playerSpeed;  //determines the baseline speed (in m/s) of the player movement
        public double playerWidth;  //hitbox width (shoulder width) of player

        //variables for player state
        public double playerMove;   //how fast the player is actually moving (in m/s)
        public int playerStatus;    //0 = standing, 1 = ducking, 2 = running, 3 = hit, 4 = out

        //variables for input handling
        public int keyTopClass;  //determines top class of action key being pressed
        public int keyNum;  //number of keys being pressed
        int dirKeyNum;  //determines which direction key is being pressed (to avoid overlap); 0 = idle, 1 = left, 2 = right
        bool[] dirKeyArray; //is key down; 0 = enter, 1 = left, 2 = right, 3 = shift, 4 = ctrl
        public void inputKey(object sender, KeyEventArgs e)
        {
            keyNum++;
            //if (!gameOver)
            if (playerStatus < 3)   //if player is not recovering from a hit or out
            {
                //move player (l/r)
                if (e.KeyCode == Keys.Left && playerPos >= 0)
                {
                    dirKeyNum = 1;
                }
                if (e.KeyCode == Keys.Right && playerPos <= playerMaxPos - playerWidth)
                {
                    dirKeyNum = 2;
                }
            }
        }

        public void inputKeyUp(object sender, KeyEventArgs e)
        {
            if (keyNum >= 0)    //if keyNum is not negative
            {
                keyNum--;
            }
        }
    }
}
