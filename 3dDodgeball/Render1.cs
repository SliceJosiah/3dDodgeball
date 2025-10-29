using System;
using System.Collections.Generic;
using System.Drawing.Text;
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
        static readonly double ym = Math.Sqrt(0.5);
        public Render1(Player1 player1d, Enemies1 enemies1b, Game2 game2b)
        {
            player1 = player1d;
            enemies1 = enemies1b;
            game2 = game2b;
        }
        public void RenderGraphics(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < GameUpd1.enemyCount; i++)
            {
                g.FillRectangle(Brushes.Red, Convert.ToSingle(enemies1.enemyPos[i] * 100), Convert.ToSingle((3 - enemies1.enemyHeight[i]) * 100 * ym), Convert.ToSingle(enemies1.enemyWidth[i] * 100), Convert.ToSingle(enemies1.enemyHeight[i] * 100 * ym));
                g.FillEllipse(Brushes.Green, Convert.ToSingle((enemies1.ball[i].ballX - enemies1.ball[i].ballRadius) * 100), game2.ClientSize.Height - Convert.ToSingle((enemies1.ball[i].ballY + enemies1.ball[i].ballZ - enemies1.ball[i].ballRadius) * 100 * ym), Convert.ToSingle(enemies1.ball[i].ballRadius * 200), Convert.ToSingle(enemies1.ball[i].ballRadius * 200));
            }
            g.FillRectangle(Brushes.Cyan, Convert.ToSingle(player1.playerPos * 100), game2.ClientSize.Height - Convert.ToSingle(player1.playerHeight * 100 * ym), Convert.ToSingle(player1.playerWidth * 100), Convert.ToSingle(player1.playerHeight * 100 * ym));
            g.FillRectangle(Brushes.Green, 0, 0, Convert.ToSingle(game2.ClientSize.Width * player1.playerHealth), 50);
        }
    }
}
