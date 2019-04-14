using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    public class Background
    {
        public Color SkyColor { get; set; }
        public Color FloorColor { get; set; }

        public void Paint(object sender, PaintEventArgs e)
        {
            int width = Settings.PictureBoxWidth;
            int heigth = Settings.PictureBoxHeight;
            int groundHeigth = Settings.PictureBoxGroundHeight;

            e.Graphics.FillRectangle(new SolidBrush(FloorColor), new Rectangle(0, groundHeigth, width, heigth-groundHeigth));
            e.Graphics.FillRectangle(new SolidBrush(SkyColor), new Rectangle(0, 0, width, groundHeigth));
        }
    }
}
