using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class Player1
    {
        Physics1 physics1 = new Physics1();

        //variables for player properties
        public double playerPos {get; set;}    //player position on x axis (distance from left in m)
        public double playerMaxPos;  //maximum distance from right side (in m) (should be same as enemyMaxPos)
        public double playerSpeed;  //determines the baseline speed (in m/s) of the player movement
        public double playerWidth;  //hitbox width (shoulder width) of player
        public double playerMiddle; //x axis position of the centre of the player

        //variables for player state
        public double playerSpeedMult = 0;   //number to multiply playerSpeed by for playerMove
        public double playerMove = 0;   //how fast the player is actually moving (in m/s)
        public int playerStatus = 0;    //0 = standing, 1 = running, 2 = crouching, 3 = hit, 4 = out
        public double playerHealth = 1; //percentage player health (in deciman)

        //variables for input handling
        public int keyTopClass;  //determines top class of action key being pressed
        public int keyNum;  //number of keys being pressed

        //integers for defining the effect of keys based on input order (for avoiding overlap and queuing)
        int keyTogDir;  //for move direction; 0 = idle, 1 = left, 2 = right; last pressed takes priority
        int keyTogState;    //for player state; 0 = standing, 1 = running, 2 = crouching; first pressed takes priority

        //integers for parrying ball
        int parryState;    //0 = not parrying, 1 = not parrying, but key is down (seperate to prevent spamming), 2 = parrying, 3 = disabled
        double parryTimer = 0;  //universal timer used for parrying times

        bool[] keyDown = new bool[108]; //is key down; 0 = enter, 1 = left, 2 = right, 3 = lshift, 4 = lctrl, 5 = z
        public void inputKey(object sender, KeyEventArgs e)
        {
            keyNum++;   //add key to keynum
            
            if (e.KeyCode == Keys.Enter)
            {
                keyDown[0] = true;
            }
            if (e.KeyCode == Keys.Left && playerPos >= 0)
            {
                keyDown[1] = true;
                keyTogDir = 1;
            }
            if (e.KeyCode == Keys.Right && playerPos <= playerMaxPos - playerWidth)
            {
                keyDown[2] = true;
                keyTogDir = 2;
            }
            if (e.KeyCode == Keys.LShiftKey)
            {
                keyDown[3] = true;
                if (keyTogState == 0)    //if player should be standing
                {
                    keyTogState = 1;    //player should be running
                }
            }
            if (e.KeyCode == Keys.LControlKey)
            {
                keyDown[4] = true;
                if (keyTogState == 0)    //if player should be standing
                {
                    keyTogState = 2;    //player should be crouching
                }
            }
            if (e.KeyCode == Keys.Z)
            {
                keyDown[5] = true;
            }
        }

        public void inputKeyUp(object sender, KeyEventArgs e)
        {
            if (keyNum > 0)    //if keyNum is not negative
            {
                keyNum--;   //subtract key from keynum
            }

            if (e.KeyCode == Keys.Enter)
            {
                keyDown[0] = false;
            }
            if (e.KeyCode == Keys.Left && playerPos >= 0)
            {
                keyDown[1] = false;
                if (keyDown[2] = true)  //if right key is also being pressed
                {
                    keyTogDir = 2;   //player direction should be right
                }
                else
                {
                    keyTogDir = 0;   //player should be idle
                }
            }
            if (e.KeyCode == Keys.Right && playerPos <= playerMaxPos - playerWidth)
            {
                keyDown[2] = false;
                if (keyDown[1] = true)  //if right key is also being pressed
                {
                    keyTogDir = 1;   //player direction should be left
                }
                else
                {
                    keyTogDir = 0;   //player should be idle
                }
            }
            if (e.KeyCode == Keys.LShiftKey)
            {
                keyDown[3] = false;
                if (keyDown[4] = true)  //if lctrl key is also being pressed
                {
                    keyTogState = 2;    //player should be crouching
                }
                else
                {
                    keyTogState = 0;    //player should be standing
                }
            }
            if (e.KeyCode == Keys.LControlKey)
            {
                keyDown[4] = false;
                if (keyDown[3] = true)  //if lshift key is also being pressed
                {
                    keyTogState = 1;    //player should be running
                }
                else
                {
                    keyTogState = 0;    //player should be standing
                }
            }
            if (e.KeyCode == Keys.Z)
            {
                keyDown[5] = false;
                if (parryState == 1)
                {
                    parryState = 0;
                }
            }
        }

        public void updatePlayer ()
        {
            if (playerStatus < 3)   //if player is not hit or out
            {
                playerStatus = keyTogState;

                //movement
                if (keyTogDir == 1) //if player should be moving left
                {
                    if (playerPos <= 0)  //if player is behind or at the maximum left
                    {
                        playerPos = 0;  //player should be at 0
                        playerSpeedMult = 0;    //player does not move
                    }
                    playerSpeedMult = -1;    //player moves towards left
                }
                if (keyTogDir == 2)  //if player should be moving right
                {
                    if (playerPos > playerMaxPos - playerWidth)  //if player is ahead of or at the maximum right
                    {
                        playerPos = playerMaxPos - playerWidth; //player should be at the end of the maximum width
                        playerSpeedMult = 0;    //player does not move
                    }
                    playerSpeedMult = 1; //player moves away from left
                }
                if  (keyTogDir == 0) //if player should not be moving
                {
                    playerSpeedMult = 0; //player does not move
                }
                if (playerStatus == 1)   //if player is running
                {
                    playerSpeedMult *= 2;    //player moves at twice the speed
                }
                if (playerStatus == 2)   //if player is crouching
                {
                    playerSpeedMult *= 0.25; //player moves at a quarter of the speed
                }

                playerMove = (playerSpeed * playerSpeedMult);   //player move speed is equal to the base player speed times the player speed multiplication value
                playerPos += playerMove;
            }
        }
    }
}
