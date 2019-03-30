using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    class BackgroundBuilder : IBackgroundBuilder
    {
        public Background Background = new Background();

        public Background GetBackground()
        {
            return Background;
        }

        public void SetFloorColor(Color color)
        {
            Background.FloorColor = color;
        }

        public void SetSkyColor(Color color)
        {
            Background.SkyColor = color;
        }

    }
}
