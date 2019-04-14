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

        public override Obstacle GetObstacle()
        {
            PointF[] points = new PointF[3];
   
            points[0] = new PointF(Settings.PictureBoxWidth + 20, 220);
            points[1] = new PointF(Settings.PictureBoxWidth, Settings.PictureBoxGroundHeight);
            points[2] = new PointF(Settings.PictureBoxWidth+40, Settings.PictureBoxGroundHeight);

            return new Spike(points, Color.Black);
        }
    }
}
