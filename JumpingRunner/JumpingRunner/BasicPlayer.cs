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
        public BasicPlayer(Rectangle shape, Color color) : base(shape, color)
        {
        }

        public override void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color), Shape);
        }

        public override void Update()
        {
            _yVelocity += _gravity;

            var temp = Shape;
            temp.Offset(0, (int) _yVelocity);
            Shape = temp;

            if (Shape.Bottom > Settings.PictureBoxGroundHeight) {
                Shape.Offset(0, Shape.Bottom - Settings.PictureBoxGroundHeight);

                _yVelocity = 0.0f;
                IsOnGround = true;
            }
        }

        public override void StartJump()
        {
            if (IsOnGround) {
                _yVelocity = _jumpSpeed;
                IsOnGround = false;
            }
        }

        public override void EndJump()
        {
            if (_yVelocity < -10.0f) {
                _yVelocity = -10.0f;
            }
        }
    }
}
