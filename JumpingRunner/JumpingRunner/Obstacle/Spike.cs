using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace JumpingRunner.Obstacle
{
    class Spike : Obstacle
    {
        public Spike(PointCollection points, System.Drawing.Color color) : base(points, color)
        {
        }

        public override EObstacleType Type()
        {
            return EObstacleType.Spike;
        }
    }
}
