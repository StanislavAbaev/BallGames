using System.Drawing;
using System.Windows.Forms;

namespace BallGames.Common
{
    public class Ball
    {
        private Form form;
        private System.Windows.Forms.Timer timer;

        protected float vx = 1;
        protected float vy = 1;
        protected float centerX = 10;
        protected float centerY = 10;
        protected int radius = 20;
        
        
        public Brush brush = Brushes.Red;
        public Ball(Form form)
        {
            this.form = form;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();

        }
        public void Stop()
        {
            timer.Stop();
            vx=0; vy = 0;
        }
        public virtual bool isMoveable()
        {
            return (vx > 0 && vy < 0);
        }
        public bool IsIntercect (Ball other)
        {
            var dx = centerX - other.centerX;
            var dy = centerY - other.centerY;
            return dx*dx +dy*dy <= Math.Pow(radius + other.radius,2);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        public virtual void Show()
        {
            Draw(brush);
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public void Clear()
        {
            var brush = SystemBrushes.Control;
            Draw(brush);
        }

        public bool Contains(int xPoint, int yPoint)
        {
            var dx = xPoint - centerX;
            var dy = yPoint - centerY;

            return (dx * dx + dy * dy <= radius * radius);
        }
        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }
        
        public virtual bool CheckCoordinates()
        {
            return (centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide());
        }
        public void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2*radius, 2*radius);
            graphics.FillEllipse(brush, rectangle);
        }
        public float ReturnCenterX()
        {
            return centerX;
        }
        public float ReturnCenterY()
        {
            return centerY;
        }
        public int RetrunRadius()
        {
            return radius;
        }


        /// <summary>
        /// Я сделал эту функцию, чтобы убирать шарики с формы,
        /// а то возникала такая ситуация, что фактически шарик, 
        /// который уже засчитан и не должен учитываться при пересечении его мышкой,
        /// все равно добавлял числа к текущему счету игрока
        /// этой функцией я сразу убил двух зайцев: убираю засчитаные шарики с формы,
        /// а также убираю те шарики, которые вышли за границы формы 
        /// </summary>
        public void ChangeBallPosition()
        {
            centerX = -100;
            centerY = -100;
            Stop();
        }
    }
}
