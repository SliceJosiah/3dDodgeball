using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class physTestVert1
    {
        //ball location arrays
        double ballX;
        double ballY;
        double maxDist1 = 10;
        double ballVelX;
        double ballVelY;
        Random random = new Random(Guid.NewGuid().GetHashCode());   //found this code on stackoverflow for a decent random seed generator, uses the hash code for a new guid integer as a seed

        private void init1()
        {
            //ballVelX = Math.Sqrt((2*-9.8*2.5)/( ));
            ballVelX = Math.Sqrt((2*-9.8*-1)/(Math.Pow(-0.5, 2)-1));
        }

        private void draw1(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
        }

        
    }
}
