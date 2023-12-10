namespace AngryBirdsWinFormsApp
{
    public partial class MainForm : Form
    {
        private BirdBall ball;
        private PigBall pigBall;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (ball.IsIntercect(pigBall))
            {
                scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text)+1).ToString();
                CreateNewBird();
                CreateNewPig();
            }
            if (!ball.isMoveable())
            {
                CreateNewBird();
            }
            if (ball.IsOutside())
            {
                CreateNewBird();
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ball.SetVSpeed(e.X, e.Y);
            timer.Start();
            ball.Start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            scoreLabel.Text = "0";
            CreateNewBird();
            CreateNewPig();
        }
        private void CreateNewBird()
        {
            timer.Stop();

            if (ball != null)
            {
                ball.Stop();
                ball.Clear();
            }
            ball = new BirdBall(this);
            ball.Show();
        }
        private void CreateNewPig()
        {
            if (pigBall != null)
            {
                pigBall.Clear();
            }
            pigBall = new PigBall(this);
            pigBall.Show();
        }
    }
}