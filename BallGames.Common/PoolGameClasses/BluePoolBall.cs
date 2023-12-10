using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGames.Common
{
    public class BluePoolBall : PoolBall
    {
        
        public BluePoolBall(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), RightSide()/2);
            brush = Brushes.Blue;
        }
        public override void Show()
        {
            Draw(brush);
        }
    }
}
