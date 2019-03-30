using System.Drawing;
using System.Windows.Forms;

namespace JumpingRunner.Obstacles
{
    public abstract class Obstacle
    {
        public PointF[] Points = new PointF[4];
        public Color Color { get; set; }
        public int XVelocity { get; set; } = 4;

        public abstract EObstacleType Type();

        public Obstacle(PointF[] points, Color color)
        {
            Points = points;
            Color = color;
        }

        public void Update()
        {

            for (int i=0; i<Points.Length; i++)
            {
                Points[i].X -= XVelocity;
            }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPolygon(new SolidBrush(Color), Points);
        }
    }
}
