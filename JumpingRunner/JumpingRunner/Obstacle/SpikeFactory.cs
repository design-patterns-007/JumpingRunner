﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace JumpingRunner.Obstacle
{
    class SpikeFactory : ObstacleFactory
    {
        public override Obstacle GetObstacle(Point[] pointCollection, System.Drawing.Color color)
        {
            return new Spike(pointCollection, color);
        }
    }
}
