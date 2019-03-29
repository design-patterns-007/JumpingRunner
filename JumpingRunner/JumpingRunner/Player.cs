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
        protected float _gravity = 0.5f;
        protected float _jumpSpeed = -15.0f;
        protected float _yVelocity = 0.0f;
        
        public Color Color { get; set; }
        public Rectangle Shape { get; set; }
        public bool IsOnGround { get; set; }
        public bool IsAlive { get; set; }

        public Player(Rectangle shape,Color color)
        {
            Shape = shape;
            Color = color;
        }

        public abstract void Paint(object sender, PaintEventArgs e);

        public abstract void Update();

        public abstract void StartJump();

        public abstract void EndJump();
    }
}
