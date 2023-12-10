using BallGames.Common;

namespace BallGamesMouseClickApp
{
    public partial class MainFormMouseClick : Form
    {
        Game game = new Game();
        public MainFormMouseClick()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.GetBalls(this);
        }

        private void MainFormMouseClick_MouseDown(object sender, MouseEventArgs e)
        {
            game.CheckClick(e.X, e.Y, scoreLabel);
        }

        private void clearFieldButton_Click(object sender, EventArgs e)
        {
            game.StopBalls(this);
            game.ResetGraphics(this);
            game.ResetScore();
            scoreLabel.Text = game.GetScore();
        }
    }
}