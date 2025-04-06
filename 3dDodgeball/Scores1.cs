using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class Scores1
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public double Time { get; set; }
        public Scores1(string name, int score, double time)
        {
            Name = name;
            Score = score;
            Time = time;
        }
    }
}
