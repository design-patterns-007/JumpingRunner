using System;
using System.Collections.Generic;
using System.Drawing;

namespace JumpingRunner.Obstacle
{
    class Pit : Obstacle
    {
        public Pit(Point[] points, Color color) : base(points, color)
        {
        }

        public override EObstacleType Type()
        {
            return EObstacleType.Pit;
        }
    }
}
