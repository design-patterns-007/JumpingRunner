using System;
using System.Collections.Generic;
using System.Drawing;

namespace JumpingRunner.Obstacle
{
    class Spike : Obstacle
    {
        public Spike(Point[] points, Color color) : base(points, color)
        {
        }

        public override EObstacleType Type()
        {
            return EObstacleType.Spike;
        }
    }
}
