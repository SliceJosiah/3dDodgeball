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
        public double ballX;
        public double ballY;
        public double ballZ;
        double ballXvel;
        double ballYvel;
        double ballZvel;
        public double ballRadius = 0.1;
        double hitStrength;
        double dropTime;
        const double gravity = 9.81;
        int bounces;

        public Ball(Player1 player1c)
        {
            player1 = player1c;
        }

        public void prepareBall(double throwAngleHor, double ballSpeed, double ballTime, double startX, double enemyWidth, double enemyHeight)
        {
            ballX = startX;
            ballY = GameUpd1.courtLength;
            ballZ = enemyHeight - enemyWidth; //initial height of ball when thrown
            ballXvel = ballSpeed * Math.Sin(throwAngleHor);
            ballYvel = ballSpeed * Math.Cos(throwAngleHor);
            ballZvel = 0;
            dropTime = ballTime;
            hitStrength = ballSpeed * 0.0142857142857;
            bounces = 0;
        }

        public void ballUpd()
        {
            if (thrown)
            {
                ballX += ballXvel/100;  //Increase the X value of the ball by its X velocity divided by 100
                ballY -= ballYvel/100;  //Decrease the Y value of the ball by its Y velocity divided by 100
                ballZvel -= gravity/100;    //Decelerate the Z velocity of the ball by gravity divided by 100
                ballZ += ballZvel/100;  //Decelerate the Z value of the ball by its Z velocity divided by 100
                
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
                if (ballX <= 0) {   //if ball has hit the floor
                    bounces ++; //add to bounce number
                    ballX = 0;  //put ball on floor
                    if (bounces >= 4) { //if this is the fourth time the ball has hit the ground
                        thrown = false;
                    } else {
                        ballXvel *= 0.9;    //damp the X velocity by x0.9
                        ballYvel *= 0.9;    //damp the Y velocity by x0.9
                        ballZvel *= -0.5;   //reverse the Z velocity and damp it by x0.5
                    }
                }
            }
        }
    }
}
