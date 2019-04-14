using System.Drawing;

namespace JumpingRunner.Obstacles
{
    class PitFactory : ObstacleFactory
    {
        public override Obstacle GetObstacle()
        {
            PointF[] points = new PointF[4];            
            points[0] = new PointF(Settings.PictureBoxWidth, Settings.PictureBoxGroundHeight-1);
            points[1] = new PointF(Settings.PictureBoxWidth + 90, Settings.PictureBoxGroundHeight - 1);
            points[3] = new PointF(Settings.PictureBoxWidth, Settings.PictureBoxHeight);
            points[2] = new PointF(Settings.PictureBoxWidth + 90, Settings.PictureBoxHeight);
            
            return new Spike(points, Color.OrangeRed);
        }
    }
}
