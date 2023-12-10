namespace SalutWinFormsApp
{
    public class SalutBallFromBottom : SalutBall
    {
        public event EventHandler<EventArgs> OnMaxY;
        public SalutBallFromBottom(Form form, int x, int y) : base(form, x, y)
        {
            centerY = y;
            centerX = x;
            vy = -10;
            vx = random.Next(-10, 10);
        }

        protected override void Go()
        {
            if (vy > 0)
                OnMaxY?.Invoke(this, new EventArgs());
            base.Go();
        }
    }
}
