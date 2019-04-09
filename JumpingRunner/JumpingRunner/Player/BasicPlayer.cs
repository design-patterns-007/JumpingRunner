using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    class BasicPlayer : Player
    {
        public BasicPlayer(Rectangle shape, Color color)
        {
            Shape = shape;
            Color = color;
            IsAlive = true;
        }

        public override void Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color);
            e.Graphics.FillRectangle(brush, Shape);
        }
    }
}
