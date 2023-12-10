using BallGames.Common;
using BallGames.Common.PoolGameClasses;
using System.Windows.Forms;

namespace PoolGameWinFormsApp
{

    public partial class MainForm : Form
    {
        private List<Ball> balls = new List<Ball>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddBalls(6);
        }

        private void Ball_OnCrossed(object? sender, CrossedEventArgs e)
        {
            if (isMixed())
                StopGame();
        }

        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            if (e.Brush == Brushes.Red && e.Side == Side.Left)
                redLeftLabel.Text = (Convert.ToInt32(redLeftLabel.Text) + 1).ToString();

            if (e.Brush == Brushes.Red && e.Side == Side.Right)
                redRightLabel.Text = (Convert.ToInt32(redRightLabel.Text) + 1).ToString();

            if (e.Brush == Brushes.Red && e.Side == Side.Top)
                redTopLabel.Text = (Convert.ToInt32(redTopLabel.Text) + 1).ToString();

            if (e.Brush == Brushes.Red && e.Side == Side.Down)
                redDownLabel.Text = (Convert.ToInt32(redDownLabel.Text) + 1).ToString();

            if (e.Brush == Brushes.Blue && e.Side == Side.Left)
                blueLeftLabel.Text = (Convert.ToInt32(blueLeftLabel.Text) + 1).ToString();

            if (e.Brush == Brushes.Blue && e.Side == Side.Right)
                blueRightLabel.Text = (Convert.ToInt32(blueRightLabel.Text) + 1).ToString();

            if (e.Brush == Brushes.Blue && e.Side == Side.Top)
                blueTopLabel.Text = (Convert.ToInt32(blueTopLabel.Text) + 1).ToString();

            if (e.Brush == Brushes.Blue && e.Side == Side.Down)
                blueDownLabel.Text = (Convert.ToInt32(blueDownLabel.Text) + 1).ToString();

        }

        private bool isMixed()
        {
            int blueBallsInLeftSide = 0;
            int blueBallsInRightSide = 0;
            int redBallsInLeftSide = 0;
            int redBallsInRightSide = 0;
            foreach (var ball in balls)
            {
                if (ball.ReturnCenterX() < ClientSize.Width / 2)
                {
                    if (ball.brush == Brushes.Red) redBallsInLeftSide++;
                    if (ball.brush == Brushes.Blue) blueBallsInLeftSide++;
                }
                if (ball.ReturnCenterX() > ClientSize.Width / 2)
                {
                    if (ball.brush == Brushes.Red) redBallsInRightSide++;
                    if (ball.brush == Brushes.Blue) blueBallsInRightSide++;
                }
            }

            if (blueBallsInLeftSide == redBallsInLeftSide
                && blueBallsInRightSide == redBallsInRightSide
                && blueBallsInLeftSide == blueBallsInRightSide
                && redBallsInLeftSide == redBallsInRightSide) return true;
            return false;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            StopGame();
        }
        private void AddBalls(int countOfBalls)
        {
            for (int i = 0; i < countOfBalls; i++)
            {
                BluePoolBall bluePoolBall = new BluePoolBall(this);
                RedPoolBall redPoolBall = new RedPoolBall(this);

                balls.Add(bluePoolBall);
                balls.Add(redPoolBall);

                bluePoolBall.OnHited += Ball_OnHited;
                bluePoolBall.Start();
                bluePoolBall.OnCrossed += Ball_OnCrossed;

                redPoolBall.OnHited += Ball_OnHited;
                redPoolBall.Start();
                redPoolBall.OnCrossed += Ball_OnCrossed;
            }

        }
        private void StopGame()
        {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Stop();
            }
        }
    }
}