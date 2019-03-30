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
            //points[0] = new PointF(620, 240);
            //points[1] = new PointF(600, 280);
           // points[2] = new PointF(640, 280);


            points[0] = new PointF(Settings.PictureBoxWidth + 20, 240);
            points[1] = new PointF(Settings.PictureBoxWidth, 280);
            points[2] = new PointF(Settings.PictureBoxWidth+40, 280);

            return new Spike(points, Color.Black);
        }
    }
}
