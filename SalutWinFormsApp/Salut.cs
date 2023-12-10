namespace SalutWinFormsApp
{
    public partial class Salut : Form
    {
        private List<SalutBall> balls = new List<SalutBall>();
        public Salut()
        {
            InitializeComponent();
        }
        private void Salut_MouseDown(object sender, MouseEventArgs e)
        {
            var random = new Random();
            var countOfBalls = random.Next(1, 11);
            for (int i = 0; i < countOfBalls; i++)
            {
                var salut = new SalutBall(this, e.X, e.Y);
                salut.Start();
            }
        }

        private void lowSalutButton_Click(object sender, EventArgs e)
        {
            var salut = new SalutBallFromBottom(this, ClientSize.Width / 2, ClientSize.Height);
            balls.Add(salut);
            salut.Start();
            salut.OnMaxY += Salut_OnMaxY;
        }

        private void Salut_OnMaxY(object? sender, EventArgs e)
        {
            var ball = balls[0];

            if (ball.GetVy() <= 0.42 && ball.GetVy() >= 0.4)
            {
                ball.Stop();
                ball.Clear();

                var random = new Random(0);
                var countOfBalls = random.Next(1, 11);
                for (int i = 0; i < countOfBalls; i++)
                {
                    var salut = new SalutBall(this, (int)ball.ReturnCenterX(), (int)ball.ReturnCenterY());
                    salut.Start();
                }
                balls.Remove(ball);
            }
        }
    }
}