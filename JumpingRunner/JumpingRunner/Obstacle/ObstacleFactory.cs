using System.Drawing;

namespace JumpingRunner.Obstacle
{
    abstract class ObstacleFactory
    {
        public abstract Obstacle GetObstacle(Point[] pointCollection, Color color);
    }
}
