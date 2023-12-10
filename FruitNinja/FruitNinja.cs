using BallGames.Common;
using FruitNinjaWinFormsApp;
using SalutWinFormsApp;

namespace FruitNinja
{
    public partial class FruitNinja : Form
    {
        private List<FruitBall> balls = new List<FruitBall>();
        private FruitBall ball;
        private Random random = new Random();
        private bool bananaBallisClicked = false;
        private int secondsRemaining = 6;
        public FruitNinja()
        {
            InitializeComponent();
        }

        private void FruitNinja_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var ball in balls)
            {
                if (ball.Contains(e.X, e.Y) && ball is CherryBall)
                {
                    AddScore(ball);
                }

                if (ball.Contains(e.X, e.Y) && ball is BananaBall)
                {
                    AddScore(ball);

                    secondsRemaining = 5;
                    bananaBallisClicked = true;
                    bananaBonusTimer.Start();

                    foreach (var ball1 in balls) ball1.LowSpeedFromBananaBall();
                }

                if (ball.Contains(e.X, e.Y) && ball is BombBall)
                {
                    StopBalls();
                    timer1.Stop();
                    MessageBox.Show("Игра окончена! Ваш счет: " + scoreLabel.Text);
                }

                if (ball.CheckCoordinates())
                {
                    ball.Stop();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var randomNumber = random.Next(0, 100);
            if (randomNumber <= 25) ball = new BombBall(this, ClientSize.Width / 2, ClientSize.Height);
            else if (randomNumber <= 100 && randomNumber >= 51) ball = new CherryBall(this, ClientSize.Width / 2, ClientSize.Height);
            else ball = new BananaBall(this, ClientSize.Width / 2, ClientSize.Height);
            if (bananaBallisClicked) ball.LowSpeedFromBananaBall();
            balls.Add(ball);
            ball.Start();
        }

        private void FruitNinja_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void StopBalls()
        {
            foreach (var ball in balls) ball.Stop();
        }
        private void AddScore(FruitBall ball)
        {
            ball.Stop();
            ball.Clear();
            ball.ChangeBallPosition();
            scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
        }

        private void bananaBonusTimer_Tick(object sender, EventArgs e)
        {
            if (secondsRemaining > 0)
            {
                secondsRemaining--;
                secondsRemainingLabel.Text = secondsRemaining.ToString();
            }
            else
            {
                bananaBonusTimer.Stop();
                secondsRemaining = 6;
                secondsRemainingLabel.Text = "";
                bananaBallisClicked = false;
                foreach (var ball in balls) ball.NormalSpeedFromBananaBall();
            }
        }
    }
}