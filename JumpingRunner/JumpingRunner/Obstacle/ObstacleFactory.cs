using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Drawing;

namespace JumpingRunner.Obstacle
{
    abstract class ObstacleFactory
    {
        public abstract Obstacle GetObstacle(Point[] pointCollection, System.Drawing.Color color);
    }
}
