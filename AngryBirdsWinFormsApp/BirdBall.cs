using BallGames.Common;

namespace AngryBirdsWinFormsApp
{
    public class BirdBall : MoveBall
    {
        private int speedFactorX = 25;
        private int speedFactorY = 19;
        private float elastic = 0.7f;
        private float g;

        public BirdBall(Form form) : base(form)
        {
            centerX = LeftSide();
            centerY = DownSide();
            radius = 20;
            g = 0.6f;
        }
        public void SetVSpeed(float numberX, float numberY)
        {
            vx = (numberX - centerX) / speedFactorX;
            vy = (numberY - centerY) / speedFactorY;
        }
        protected override void Go()
        {
            base.Go();
            if (centerY > DownSide())
            {
                vy = -vy;
                centerY = DownSide();
                vx *= elastic;
                vy *= elastic;

            }
            if (vx < 0.1 && vy < 0.1)
            {
                Stop();
                Clear();
            }

            vy += g;
        }
        public override bool isMoveable()
        {
            return (vx != 0 && vy != 0);
        }

        private bool CheckSideCoordinates()
        {
            if (centerX - radius * 2 > RightSide()) return true;
            if ((centerY + radius * 2 < TopSide()) && (centerX - radius * 2 > RightSide())) return false;
            else return false;
        }
        public bool IsOutside()
        {
            return centerX > RightSide();
        }

        public void ReturnToStartPosition(Form form)
        {
            centerX = LeftSide();
            centerY = DownSide();
        }
    }
}
