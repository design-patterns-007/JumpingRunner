using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace JumpingRunner.Obstacle
{
    class Obstacle
    { 
        public PointCollection PointCollection = new PointCollection();
        public System.Drawing.Color Color { get; set; }
        public int XVelocity { get; set; } = 10;
        
        public Obstacle(PointCollection points, System.Drawing.Color color)
        {
            PointCollection = points;
            Color = color;
        }

        public void Update()
        {
            for(int i=0; i<PointCollection.Count(); i++)
            {
                PointCollection[i].Offset(-XVelocity, 0);
            }
        }

        public void Paint()
        {

        }
    }
}
