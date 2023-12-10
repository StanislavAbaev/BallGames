using System.Windows.Forms;
using BallGames.Common.PoolGameClasses;

namespace BallGames.Common
{
    public class PoolBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public event EventHandler<CrossedEventArgs> OnCrossed;
        
        public PoolBall(Form form) : base(form)
        {

        }

        protected override void Go()
        {
            base.Go();

            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left, this));
            }
            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right, this));
            }
            if (centerY <= TopSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top, this));
            }
            if (centerY >= DownSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down, this));
            }

            OnCrossed.Invoke(this, new CrossedEventArgs());
        }

        public override void Show()
        {
            base.Show();
        }
        



    }
}
