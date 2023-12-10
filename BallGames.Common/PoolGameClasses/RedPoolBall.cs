using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BallGames.Common.PoolGameClasses;

namespace BallGames.Common
{
    public class RedPoolBall : PoolBall
    {

        public RedPoolBall(Form form) : base(form)
        {
            centerX = random.Next(RightSide() / 2, RightSide());
            brush = Brushes.Red;
        }
        public override void Show()
        {
            Draw(brush);
        }
    }
}
