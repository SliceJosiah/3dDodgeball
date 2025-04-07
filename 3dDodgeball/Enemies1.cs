using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class Enemies1
    {
        Player1 player1 = new Player1();

        //variables for all enemy behaviour
        public double enemyPosLine { get; set; }    //distance between enemy position line and top of form, defined in form
        public double enemyPosMax { get; set; } //horizontal space enemies have to move, defined in form
        //public double enemyHealth { get; set; } //health level of enemies

        //variables for initial enemy properties
        public double[] enemyPos;   //enemy positions (horizontal position)
        public double[] enemyWidth;    //hitbox widths (shoulder widths) of enemies
        public double[] enemyHeight;   //enemy heights, change where enemies throw balls from
        public bool[] lefthanded;  //left handed or not, changes where enemies throw balls from

        //variables for enemy generation
        public int enemyCount { get; set; }    //number of enemies
        bool poscheckfailed = true;    //if enemy pos is overlapping
        int j;  //number enemy being position checked

        //variables for enemy actions
        public int[] enemyStatus;   //0 = no ball, 1 = holding ball, 2 = preparing to throw ball, 3 = throwing ball, 4 = just threw ball, 5 = hit, 6 = timeout, 7 = walking
        public double[] throwAngleHor; //horizontal throwing angle (in degrees)
        public double[] throwAngleVert;    //vertical throwing angle (in degrees)
        public double[] maxThrowSpeed; //maximum throwing speed (in m/s)
        double[] baseStateTime;    //base random number of seconds left for enemy status to change
        double[] fullStateTime; //full number of seconds left for enemy status change after modifiers are applied
        double[] playerDistancePerc;    //percentage distance from player ( (enemyPos-playerPos)/enemyPosMax )

        //variables for basic colours
        public string[] enemyColour;

        Random random = new Random(Guid.NewGuid().GetHashCode());   //found this code on stackoverflow for a decent random seed generator, uses the hash code for a new guid integer as a seed

        public void enemyGen()
        {
            enemyPos = new double[enemyCount];
            enemyWidth = new double[enemyCount];
            enemyHeight = new double[enemyCount];
            lefthanded = new bool[enemyCount];
            enemyStatus = new int[enemyCount];
            baseStateTime = new double[enemyCount];
            fullStateTime = new double[enemyCount];
            throwAngleHor = new double[enemyCount];
            throwAngleVert = new double[enemyCount];

            enemyColour = new string[enemyCount];
            enemyColour[0] = "Red";
            enemyColour[1] = "Blue";
            enemyColour[2] = "Green";
            enemyColour[3] = "Yellow";
            enemyColour[4] = "Magenta";


            for (int i = 0; i < enemyCount; i++)    //for each enemy (of a number which is determined by enemyCount)
            {
                j = 0;
                enemyWidth[i] = random.NextDouble() * (0.47 - 0.33) + 0.33;  //generate random enemy width between 33 cm and 47 cm
                enemyPos[i] = random.NextDouble() * (enemyPosMax - enemyWidth[i]);  //generate enemy spawn position between 0 and enemyPosMax - enemyWidth
                //make sure enemy does not spawn in the same place as another enemy
                while (j < i)  //while j 
                {
                    if ((enemyPos[i] >= enemyPos[j] && enemyPos[i] <= (enemyPos[j] + enemyWidth[j])) //if left side of enemy i is in the bounds of enemy j
                        | ((enemyPos[i] + enemyWidth[i]) >= enemyPos[j] && (enemyPos[i] + enemyWidth[i]) <= (enemyPos[j] + enemyWidth[j]))  //or if right side of enemy i is in the bounds of enemy j
                        | (enemyPos[i] <= enemyPos[j] && (enemyPos[i] + enemyWidth[i]) >= (enemyPos[j] + enemyWidth[j])))   //or if enemy i's left and right sides are at respectively lower and higher points to enemy j's left and right sides
                    {
                        j = 0;
                        enemyPos[i] = random.NextDouble() * (enemyPosMax - enemyWidth[i]);  //generate a new position
                    }
                    else j++;   //otherwise, advance
                }
                enemyHeight[i] = enemyWidth[i] * 4.5;  //enemy height is enemy width times 4.5
                baseStateTime[i] = random.NextDouble() * (5 - 10) + 10;   //generate initial baseline time, between 5 and 10 seconds (longer than usual to give the player time to react)
            }
        }

        

        public void updateEnemy()
        {
            for (int i = 0; i < enemyCount; i++)
            {
                if (enemyStatus[i] == 5) 
                {
                    baseStateTime[i] -= 0.01;
                    continue;
                }
                playerDistancePerc[i] = (player1.playerPos - enemyPos[i])/enemyPosMax;
                if (enemyStatus[i] == 0)    //if enemy is idle
                {
                    baseStateTime[i] -= 0.01;
                }
                if (enemyStatus[i] == 1)
                {
                    baseStateTime[i] -= 0.01;
                    throwAngleHor[i] = Math.Atan(10/(player1.playerPos - enemyPos[i]));

                }
            }
        }
    }
}
