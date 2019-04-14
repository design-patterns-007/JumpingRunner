using System;
using System.Collections.Generic;
using System.Drawing;

namespace JumpingRunner.Obstacles
{
    class Pit : Obstacle
    {
        public Pit(PointF[] points, Color color) : base(points, color)
        {
        }

        public override EObstacleType Type()
        {
            return EObstacleType.EPit;
        }
    }
}
