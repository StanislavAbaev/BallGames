using BallGames.Common;

namespace AngryBirdsWinFormsApp
{
    public class PigBall : RandomSizeAndPointBall
    {
        public PigBall (Form form) : base (form)
        {
            brush = Brushes.Green;
            vx = 0;
            vy = 0;
            radius = 30;
        }
    }
}
