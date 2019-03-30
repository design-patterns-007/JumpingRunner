using System;
using System.Collections.Generic;
using System.Drawing;

namespace JumpingRunner.Obstacles
{
    class Spike : Obstacle
    {
        public Spike(PointF[] points, Color color) : base(points, color)
        {
        }

        public override EObstacleType Type()
        {
            return EObstacleType.Spike;
        }
    }
}
