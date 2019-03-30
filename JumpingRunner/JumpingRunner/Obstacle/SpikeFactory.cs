using System;
using System.Drawing;

namespace JumpingRunner.Obstacle
{
    class SpikeFactory : ObstacleFactory
    {
        public override Obstacle GetObstacle(Point[] pointCollection, Color color)
        {
            return new Spike(pointCollection, color);
        }
    }
}
