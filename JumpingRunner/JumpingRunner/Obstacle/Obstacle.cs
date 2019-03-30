using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media;
using System.Windows.Shapes;

namespace JumpingRunner.Obstacle
{
    abstract class Obstacle
    { 
//        public PointCollection PointCollection = new PointCollection();
        public System.Drawing.Point[] Points = new System.Drawing.Point[4];
        public System.Drawing.Color Color { get; set; }
        public int XVelocity { get; set; } = 4;

        public abstract EObstacleType Type();

        public Obstacle(Point[] points, System.Drawing.Color color)
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
            //for(int i=0; i<PointCollection.Count(); i++)
            {
           //     PointCollection[i].Offset(-XVelocity, 0);
            }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            Polygon polygon = new Polygon();
            
            polygon.Stroke = System.Windows.Media.Brushes.Black;
            polygon.Fill = System.Windows.Media.Brushes.LightSeaGreen;
            polygon.StrokeThickness = 2;
            polygon.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            polygon.VerticalAlignment = System.Windows.VerticalAlignment.Center;
 
            e.Graphics.FillPolygon(new System.Drawing.SolidBrush(Color), Points);
        }
    }
}
