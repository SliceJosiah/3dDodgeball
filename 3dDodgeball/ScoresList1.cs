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
        string scoreFile = Application.StartupPath + @"\scores.txt";    //define location of score file
        List<Scores1> scores1 = new List<Scores1>();    //make list for scores using scores1
        public ScoresList1(string username, int pscore)
        {
            InitializeComponent();

            lblPoints.Text = "You got " + pscore.ToString() + " points!";   //display points

            if (!File.Exists(scoreFile))
            {
                File.WriteAllText(scoreFile, "Nobody,0");
            }

            var read = new StreamReader(scoreFile); //make new reader for the score file
            while (!read.EndOfStream)   //while reader is still reading scores
            {
                var lne = read.ReadLine();
                var val = lne.Split(',');
                scores1.Add(new Scores1(val[0], Int32.Parse(val[1])));
            }
            read.Close();

            scores1 = scores1.OrderByDescending(s => s.Score).ToList(); //sort list
            int lowscore = scores1.Count >= 20 ? scores1[19].Score : scores1.Last().Score;    //if there is equal to or more than 20 scores, get the 19th score. otherwise, get the last score
            if (pscore > lowscore | scores1.Count < 20)  //if player's score is in top 20
            {
                scores1.Add(new Scores1(username, pscore));  //add player's score
                scores1 = scores1.OrderByDescending(s => s.Score).ToList();  //sort list
                scores1 = scores1.Take(20).ToList();    //trim values after 20

                StringBuilder build = new StringBuilder();
                foreach (Scores1 score in scores1)  //for every score
                {
                    build.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
                }
                File.WriteAllText(scoreFile, build.ToString());
            }
            foreach (Scores1 s in scores1)  //for every entry
            {
                lstNames.Items.Add(s.Name); //add names to lstnames
                lstScores.Items.Add(s.Score);   //add scores to lstscores
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Start start = new Start();
            start.Show();
        }
    }
}
