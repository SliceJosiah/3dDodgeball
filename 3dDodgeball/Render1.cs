using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dDodgeball
{
    internal class Render1
    {
        private Player1 player1;
        private Enemies1 enemies1;
        private Game2 game2;
        static readonly double vMult = Math.Sqrt(0.5);
        public Render1(Player1 player1d, Enemies1 enemies1b, Game2 game2b)
        {
            player1 = player1d;
            enemies1 = enemies1b;
            game2 = game2b;
        }
        public void RenderGraphics(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Red, 0, 0, 10, 10);
            g.FillRectangle(Brushes.Cyan, Convert.ToSingle(player1.playerPos * 100), game2.ClientSize.Height - 100, 100, 100);
        }
    }
}
