using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class Ball
    {
        //ball location arrays. 0 is always the player ball while balls afterwards
        private Player1 player1;
        public bool thrown = false;
        double ballX;
        double ballY;
        double ballZ;
        double ballXvel;
        double ballYvel;
        double ballZvel;
        double ballRadius = 1.1;
        double hitStrength;
        double dropTime;
        //const double gravity = -9.8;

        public Ball(Player1 player1c)
        {
            player1 = player1c;
        }

        public void prepareBall(double throwAngleHor, double ballSpeed, double ballTime, double startX)
        {
            ballX = startX;
            ballY = GameUpd1.courtLength;
            ballXvel = ballSpeed * Math.Sin(throwAngleHor);
            ballYvel = ballSpeed * Math.Cos(throwAngleHor);
            dropTime = ballTime;
            hitStrength = ballSpeed * 0.0142857142857;
        }

        public void ballUpd()
        {
            if (thrown)
            {
                ballX += ballXvel/100;  //Increase the X value of the ball by its X velocity divided by 100
                ballY -= ballYvel/100;  //Decrese the Y value of the ball by its Y velocity divided by 100
                
                if (ballY <= 0)
                {
                    if (ballX > player1.playerPos - ballRadius &&  ballX < player1.playerPos + player1.playerWidth + ballRadius)    //if the ball would't hit the player, accomodating for the radius of the ball
                    {
                        player1.playerHealth -= hitStrength;    //decrese the player's health by the hitstrength
                        player1.points -= hitStrength * 2000;  //decrease the player's points by the hitstrength times 2000
                        if (player1.points < 0) //if the player's points are less than 0
                        {
                            player1.points = 0; //set the player's points to 0
                        }
                        if (player1.playerHealth <= 0)
                        {
                            player1.playerStatus = 4;   //player is out
                        }
                        else
                        {
                            player1.hitTimer1 = hitStrength * 7.5;  //set player hit timer to the hitstrength times 7.5
                            player1.playerStatus = 3;   //player has a hit timeout
                        }
                    }
                    thrown = false;
                }
            }
        }
    }
}
