using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{

    public partial class Form1 : Form
    {
        int pipeSpeed = 5;
        int gravity = 3;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer(object sender, EventArgs e)
        {
            picturebox_bird.Top += gravity;
            picturebox_top.Left -= pipeSpeed;
            pictureBox_Top1.Left -= pipeSpeed;
            label1.Text = "Score" + score;
            if (picturebox_top.Left < -150)
            {
                picturebox_top.Left = 800;
                score++;
            }
            if (pictureBox_Top1.Left < -180)
            {
                pictureBox_Top1.Left = 950;
                score++;
            }
            if (picturebox_bird.Bounds.IntersectsWith(pictureBox_Top1.Bounds) ||
                 picturebox_bird.Bounds.IntersectsWith(picturebox_top.Bounds) ||
                 picturebox_bird.Bounds.IntersectsWith(pictureBox_Ground.Bounds) || picturebox_bird.Top < -25)
            {
                EndGame();
            }
        }
        public void EndGame()
        {
            time_GameControl.Stop();
            label1.Text = "GAME OVER!";
        }


        private void pictureBox_Top1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Ground_Click(object sender, EventArgs e)
        {

        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -20;
            }
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }
    }
}

 




           





