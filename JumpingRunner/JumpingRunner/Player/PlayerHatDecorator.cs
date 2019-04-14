using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    class PlayerHatDecorator : PlayerDecorator
    {
        public PlayerHatDecorator(Player decoratedPlayer) : base(decoratedPlayer)
        {
            
        }

        public override void Paint(object sender, PaintEventArgs e)
        {
            DecoratedPlayer.Paint(sender, e);

            int hatX = DecoratedPlayer.Shape.X+5;
            int hatY = DecoratedPlayer.Shape.Y-15;
            int hatWidth = DecoratedPlayer.Shape.Width-10;
            int hatHeight = DecoratedPlayer.Shape.Height-15;

            Rectangle hat = new Rectangle(hatX, hatY, hatWidth, hatHeight);

            e.Graphics.FillRectangle(Brushes.Black, hat);
        }
    }
}
