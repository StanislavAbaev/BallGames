using BallGames.Common;
using SalutWinFormsApp;

namespace FruitNinja
{
    public class FruitBall : SalutBallFromBottom
    {
        private int speedFactor = 4;
        public FruitBall(Form form, int x, int y) : base (form, x, y)
        {
            radius = random.Next(30, 70);
            centerY = y;
            centerX = x;
            vy = random.Next(-40,-20);
        }
        public override bool CheckCoordinates()
        {
            if (centerX + radius*2 < LeftSide()) return true;
            if (centerX - radius*2 > RightSide()) return true;
            if (centerY + radius*2 < TopSide()) return true;
            if (centerY - radius*2 > DownSide()) return true;
            else return false;
            
        }
        public void LowSpeedFromBananaBall()
        {
            vy = vy / speedFactor;
        }
        public void NormalSpeedFromBananaBall()
        {
            vy = vy * speedFactor;
        }
    }
}
