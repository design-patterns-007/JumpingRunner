using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingRunner
{
    interface IBackgroundBuilder
    {
        void SetSkyColor(Color color);
        void SetFloorColor(Color color);
        Background GetBackground();
    }
}
