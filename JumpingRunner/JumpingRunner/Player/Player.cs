using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    abstract public class Player
    {
        protected float _gravity = 0.9f;
        protected float _jumpSpeed = -18.0f;
        protected float _yVelocity = 0.0f;
        
        public Color Color { get; set; }
        public Rectangle Shape { get; set; }
        public bool IsOnGround { get; set; }
        public bool IsAlive { get; set; }


        public abstract void Paint(object sender, PaintEventArgs e);

        public virtual void Update()
        {
            _yVelocity += _gravity;

            var temp = Shape;
            temp.Offset(0, (int) _yVelocity);
            Shape = temp;

            if (Shape.Bottom > Settings.PictureBoxGroundHeight) {
                int diff = Settings.PictureBoxGroundHeight- Shape.Bottom;

                var temp2 = Shape;
                temp2.Offset(0, diff);
                Shape = temp2;

                _yVelocity = 0.0f;
                IsOnGround = true;
            }
        }

        public virtual void StartJump()
        {
            if (IsOnGround) {
                _yVelocity = _jumpSpeed;
                IsOnGround = false;
            }
        }

        public virtual void EndJump()
        {
            if (_yVelocity < -10.0f) {
                _yVelocity = -10.0f;
            }
        }
    }
}
