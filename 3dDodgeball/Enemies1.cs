using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class Enemies1
    {
        private Player1 player1;    //define player1 variable
        public Ball[] ball;  //prepare ball varable for array of ball objects

        //variables for all enemy behaviour
        //public double enemyPosLine { get; set; }    //distance between enemy position line and top of form, defined in form
        //public double enemyPosMax { get; set; } //horizontal space enemies have to move, defined in form
        //public double enemyHealth { get; set; } //health level of enemies

        //variables for initial enemy properties
        public double[] enemyPos;   //enemy positions (horizontal position)
        public double[] enemyWidth;    //hitbox widths (shoulder widths) of enemies
        public double[] enemyHeight;   //enemy heights, change where enemies throw balls from
        //public bool[] lefthanded;  //left handed or not, changes where enemies throw balls from

        //variables for enemy generation
        bool poscheckfailed = true;    //if enemy pos is overlapping
        int j;  //number enemy being position checked

        //variables for enemy actions
        //Temporary note: As of 8/4/25, states above 2 are unused.
        public int[] enemyStatus;   //0 = no ball, 1 = holding ball, 2 = preparing to throw ball, 3 = throwing ball, 4 = just threw ball, 5 = hit, 6 = timeout, 7 = walking
        //public double[] maxThrowSpeed; //maximum throwing speed (in m/s)
        double[] baseStateTime;    //base random number of seconds left for enemy status to change
        //double[] fullStateTime; //full number of seconds left for enemy status change after modifiers are applied

        //variables for basic colours
        //public string[] enemyColour;

        Random random = new Random(Guid.NewGuid().GetHashCode());   //found this code on stackoverflow for a decent random seed generator, uses the hash code for a new guid integer as a seed

        public Enemies1(Player1 player1b)
        {
            player1 = player1b; //set variable
        }

        public void enemyGen()
        {
            enemyPos = new double[GameUpd1.enemyCount];
            enemyWidth = new double[GameUpd1.enemyCount];
            enemyHeight = new double[GameUpd1.enemyCount];
            //lefthanded = new bool[enemyCount];
            enemyStatus = new int[GameUpd1.enemyCount];
            baseStateTime = new double[GameUpd1.enemyCount];
            //fullStateTime = new double[enemyCount];

            ball = new Ball[GameUpd1.enemyCount];

            // enemyColour = new string[enemyCount];
            // enemyColour[0] = "Red";
            // enemyColour[1] = "Blue";
            // enemyColour[2] = "Green";
            // enemyColour[3] = "Yellow";
            // enemyColour[4] = "Magenta";


            for (int i = 0; i < GameUpd1.enemyCount; i++)    //for each enemy (of a number which is determined by enemyCount)
            {
                j = 0;
                enemyWidth[i] = random.NextDouble() * (0.47 - 0.33) + 0.33;  //generate random enemy width between 33 cm and 47 cm
                enemyPos[i] = random.NextDouble() * (GameUpd1.courtWidth - enemyWidth[i]);  //generate enemy spawn position between 0 and courtWidth - enemyWidth
                //make sure enemy does not spawn in the same place as another enemy
                while (j < i)  //while j 
                {
                    if ((enemyPos[i] >= enemyPos[j] && enemyPos[i] <= (enemyPos[j] + enemyWidth[j])) //if left side of enemy i is in the bounds of enemy j
                        | ((enemyPos[i] + enemyWidth[i]) >= enemyPos[j] && (enemyPos[i] + enemyWidth[i]) <= (enemyPos[j] + enemyWidth[j]))  //or if right side of enemy i is in the bounds of enemy j
                        | (enemyPos[i] <= enemyPos[j] && (enemyPos[i] + enemyWidth[i]) >= (enemyPos[j] + enemyWidth[j])))   //or if enemy i's left and right sides are at respectively lower and higher points to enemy j's left and right sides
                    {
                        j = 0;
                        enemyPos[i] = random.NextDouble() * (GameUpd1.courtWidth - enemyWidth[i]);  //generate a new position
                    }
                    else j++;   //otherwise, advance
                }
                ball[i] = new Ball(player1);
                enemyHeight[i] = enemyWidth[i] * 4.5;  //enemy height is enemy width times 4.5
                baseStateTime[i] = random.NextDouble() * (5 - 1) + 1;   //generate initial baseline time, between 1 and 5 seconds (previously 2.5 to 10, longer than usual to give the player time to react, but I changed it because it was way too slow)
            }
        }

        public void updateEnemy()
        {
            for (int i = 0; i < GameUpd1.enemyCount; i++)
            {
                // if (enemyStatus[i] == 5) 
                // {
                //     baseStateTime[i] -= 0.01;
                //     continue;
                // }
                ball[i].ballUpd();
                
                double playerDistancePerc = Math.Abs((enemyPos[i] - player1.playerPos)/GameUpd1.courtWidth); //distance from player, out of the court length, as a positive decimal

                if (enemyStatus[i] == 0)    //if enemy is idle
                {
                    baseStateTime[i] -= 0.01;
                    if (baseStateTime[i] <= 0) //if state timer is over
                    {
                        baseStateTime[i] = random.NextDouble() * (5 - 1) + 1 + playerDistancePerc * 2;  //generate random time until enemy starts preparing to throw the ball, between 1 and 5 seconds, plus the enemy distance from the player times two. this makes closer enemies less predictable
                        enemyStatus[i] = 1; //status = holding ball
                    }
                }
                if (enemyStatus[i] == 1)    //if enemy has ball
                {
                    baseStateTime[i] -= 0.01;
                    if (baseStateTime[i] <= 0) //if state timer is over
                    {
                        baseStateTime[i] = random.NextDouble() * (1 - 0.2) + 0.5 + playerDistancePerc * 2;  //generate random time until enemy throws ball, between 0.2 and 1 seconds, plus the enemy distance from the player times two
                        double throwAngleHor = Math.Atan2(((player1.playerMiddle/* + player1.playerMove*/) - enemyPos[i]), GameUpd1.courtLength) /*- (2.5 * (Math.PI / 180)) + random.NextDouble() * (5 * (Math.PI / 180))*/;    //generate throwing angle in radians, based on the position the player will be at in 1 second, and randomise either way by a maximum of 2.5 degrees.
                        double ballSpeed = random.NextDouble() * (20 - 6) + 6;   //generate random ball speed between 20 and 6 m/s
                        double ballTime = random.NextDouble() * (3 - 0.5) + 0.5;   //generate random ball drop time between 3 and 0.5 s. 
                        enemyStatus[i] = 2; //status = preparing to throw ball
                        ball[i].prepareBall(throwAngleHor, ballSpeed, ballTime, enemyPos[i], enemyHeight[i], enemyWidth[i]);
                    }
                }
                if (enemyStatus[i] == 2)    //if enemy is preparing to throw ball
                {
                    baseStateTime[i] -= 0.01;
                    if (baseStateTime[i] <= 0) //if state timer is over
                    {
                        baseStateTime[i] = random.NextDouble() * (8 - 4) + 4;  //generate random time until enemy starts preparing to throw the ball, between 4 and 8 seconds
                        ball[i].thrown = true;  //throw the ball
                        enemyStatus[i] = 0; //status = idle
                    }
                }
            }
        }
    }
}
