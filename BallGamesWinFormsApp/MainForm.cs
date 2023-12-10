using BallGames.Common;
namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        PointBall pointBall;
        Game game = new Game();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void createBalls_Click(object sender, EventArgs e)
        {
            game.ResetScore();
            scoreLabel.Text = game.GetScore();
            game.GetBalls(this);
        }

        private void stopBalls_Click(object sender, EventArgs e)
        {
            game.StopBalls(this);
            scoreLabel.Text = game.GetScore();
            game.ResetScore();
        }

        private void resetField_Click(object sender, EventArgs e)
        {
            game.ResetGraphics(this);
            game.ResetScore();
            scoreLabel.Text = game.GetScore();
        }
    }
}