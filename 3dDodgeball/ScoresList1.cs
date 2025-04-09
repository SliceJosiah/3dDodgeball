using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3dDodgeball
{
    public partial class ScoresList1 : Form
    {

        List<Scores1> scores1 = new List<Scores1>();
        public ScoresList1(string username, int score)
        {
            InitializeComponent();
            lblPoints.Text = "You got" + score.ToString();
        }
    }
}
