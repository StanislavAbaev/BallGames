using BallGames.Common;

namespace SalutWinFormsApp
{
    public class SalutBall : MoveBall
    {
        protected float g = 0.2f;
        public SalutBall (Form form, int centerX, int centerY) : base (form)
        {
            radius = 30;
            this.centerX = centerX;
            this.centerY = centerY;
            vy = -Math.Abs(vy);
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
        public float GetVy()
        {
            return (vy * vy) / 2 * g;
        }
    }
}
