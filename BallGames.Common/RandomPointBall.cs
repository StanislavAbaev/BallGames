namespace BallGames.Common
{
    public class RandomPointBall : Ball
    {
        protected Random random = new Random();
        public RandomPointBall(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
    }


}
