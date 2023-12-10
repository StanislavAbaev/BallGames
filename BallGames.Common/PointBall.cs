namespace BallGames.Common
{
    public class PointBall : Ball
    {
        public PointBall(Form form, int X, int Y) : base(form)
        {
            centerX = X - 35;
            centerY = Y - 35;
        }

    }


}
