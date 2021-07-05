using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class Form1 : Form
    {
        int pipespd = 5;
        int gravity = 5;
        int score = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            gameovertxt.Hide();
            restartbtn.Hide();
            bird.Hide();
            pipeTop1.Hide();
            pipebottom.Hide();
            scoretxt.Hide();
            GameTimer.Enabled = false;
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipebottom.Left -= pipespd;
            pipeTop1.Left  -= pipespd;
            scoretxt.Text = "Score : " + score; 


            if(pipebottom.Left<50)
            {
                pipebottom.Left = rand.Next(600, 800);
                pipebottom.Top = rand.Next(295, 379); 
                score++;
            }
            if(pipeTop1.Left < 0)
            {
                pipeTop1.Left = rand.Next(650, 850);
                pipeTop1.Top = rand.Next(-87, 0);
                score++;
            }
            if(bird.Bounds.IntersectsWith(pipebottom.Bounds) || bird.Bounds.IntersectsWith(pipeTop1.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endgame();
            }
            if(score > 5  && score%5 == 0)
            {
                pipespd += 1;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endgame()
        {
            GameTimer.Stop();
            gameovertxt.Show();
            scoretxt.Left =330;
            scoretxt.Top = 205;
            restartbtn.Show();

        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            logo.Hide();
            pipeTop1.Show();
            pipebottom.Show();
            bird.Show();
            scoretxt.Show();
            GameTimer.Enabled = true;
        }
    }
}
