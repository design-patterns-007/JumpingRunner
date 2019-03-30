using System.Drawing;

namespace JumpingRunner.Obstacles
{
    class PitFactory : ObstacleFactory
    {
        public override Obstacle GetObstacle(PointF[] pointCollection, Color color)
        {
            return new Pit(pointCollection, color);
        }
    }
}
