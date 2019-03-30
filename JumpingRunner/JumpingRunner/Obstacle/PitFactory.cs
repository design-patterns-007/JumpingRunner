using System.Drawing;

namespace JumpingRunner.Obstacle
{
    class PitFactory : ObstacleFactory
    {
        public override Obstacle GetObstacle(Point[] pointCollection, Color color)
        {
            return new Pit(pointCollection, color);
        }
    }
}
