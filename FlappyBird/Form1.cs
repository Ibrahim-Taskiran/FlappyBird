using System.Security.Cryptography.X509Certificates;

namespace FlappyBird
{
    public partial class FlappyBirdForm : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        public FlappyBirdForm()
        {
            InitializeComponent();
            this.KeyPreview = true; 
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            BoruUst.Left -= pipeSpeed;
            BoruAlt.Left -= pipeSpeed;
            label1.Text = "SCORE : " + score;

            if (BoruUst.Left < -150)
            {
                BoruUst.Left = 800;
                score++;
            }

            if (BoruAlt.Left < -180)
            {
                BoruAlt.Left = 950;
                score++;
            }

            if (Bird.Bounds.IntersectsWith(BoruUst.Bounds) ||
                Bird.Bounds.IntersectsWith(BoruAlt.Bounds) ||
                Bird.Bounds.IntersectsWith(Zemin.Bounds) ||
                Bird.Top < -25)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            GameTimer.Stop();
            label1.Text = "Game Over !";
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
                gravity = 15;
            }

        }

        private void FlappyBirdForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxEngelÜst_Click(object sender, EventArgs e)
        {

        }
    }
}
