using System.Drawing;

namespace JumpingRunner.Obstacles
{
    abstract class ObstacleFactory
    {
        public abstract Obstacle GetObstacle(PointF[] pointCollection, Color color);
        public abstract Obstacle GetObstacle();
    }
}
