namespace BallGames.Common.PoolGameClasses;

public class HitEventArgs
{
    public Side Side;
    public Brush Brush;
    public HitEventArgs(Side side)
    {
        Side = side;
    }
    public HitEventArgs(Side side, PoolBall ball)
    {
        Side = side;
        Brush = ball.brush;
    }
}