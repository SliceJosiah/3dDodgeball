using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _3dDodgeball
{
    public partial class ScoresList1 : Form
    {
        string scoreFile = Application.StartupPath + @"\scores.txt";
        List<Scores1> scores1 = new List<Scores1>();
        public ScoresList1(string username, int score)
        {
            InitializeComponent();
            lblPoints.Text = "You got" + score.ToString();
            var reader = new StreamReader(scoreFile);
            while (!reader.EndOfStream)
            {
                var lne = reader.ReadLine();
                var val = lne.Split(',');
                scores1.Add(new Scores1(val[0], Int32.Parse(val[1])));
            }
        }
    }
}
