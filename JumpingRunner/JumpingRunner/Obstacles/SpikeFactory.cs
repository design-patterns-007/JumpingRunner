using System;
using System.Drawing;

namespace JumpingRunner.Obstacles
{
    class SpikeFactory : ObstacleFactory
    {
        public override Obstacle GetObstacle(PointF[] pointCollection, Color color)
        {
            return new Spike(pointCollection, color);
        }
    }
}
