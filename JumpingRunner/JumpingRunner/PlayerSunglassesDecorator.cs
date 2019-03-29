using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    class PlayerSunglassesDecorator : PlayerDecorator
    {
        public PlayerSunglassesDecorator(Player decoratedPlayer) : base(decoratedPlayer)
        {
        }

        public override void Paint(object sender, PaintEventArgs e)
        {
            DecoratedPlayer.Paint(sender, e);
            int x = DecoratedPlayer.Shape.X;
            int y = DecoratedPlayer.Shape.Y;

            Rectangle lense1 = new Rectangle(x, y, 15, 15);
            Rectangle lense2= new Rectangle(x+15, y, 15, 15);

            e.Graphics.FillEllipse(Brushes.Black, lense1);
            e.Graphics.FillEllipse(Brushes.Black, lense2);
        }
    }
}
