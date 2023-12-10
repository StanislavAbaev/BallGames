using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallGames.Common
{
    public class Game
    {

        public List<MoveBall> moveBalls = new List<MoveBall>();
        private int score = 0;

        public void GetBalls(Form form)
        {
            moveBalls = new List<MoveBall>();
            var random = new Random();
            var randomNumber = random.Next(5, 15);
            for (int i = 0; i < randomNumber; i++)
            {
                var randomSizeAndPointBall = new MoveBall(form);
                moveBalls.Add(randomSizeAndPointBall);
                moveBalls[i].Start();
            }
        }
        public void StopBalls(Form form)
        {
            foreach (var ball in moveBalls)
            {
                ball.Stop();
                if (ball.CheckCoordinates()) score++;
            }
        }

        public void CheckClick(int X, int Y, Label scoreLabel)
        {
            foreach (var ball in moveBalls)
            {
                if (ball.Contains(X, Y))
                {
                    AddPointToScore();
                    ball.Stop();
                    scoreLabel.Text = GetScore();
                    ball.ChangeBallPosition();
                }
            }
        }


        public string GetScore()
        {
            return score.ToString();
        }
        public void AddPointToScore()
        {
            score++;
        }
        public void ResetScore()
        {
            score = 0;
        }
        public void ResetGraphics(Form form)
        {
            var graphics = form.CreateGraphics();
            graphics.Clear(SystemColors.Control);
        }
        
    }
}
