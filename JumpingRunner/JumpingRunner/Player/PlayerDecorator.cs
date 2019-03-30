using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    abstract class PlayerDecorator : Player
    {
        public Player DecoratedPlayer { get; set; }

        public PlayerDecorator(Player decoratedPlayer)
        {
            DecoratedPlayer = decoratedPlayer;
            Shape = DecoratedPlayer.Shape;
            IsAlive = DecoratedPlayer.IsAlive;
        }

        public override void Update()
        {
            DecoratedPlayer.Update();
            Shape = DecoratedPlayer.Shape;
        }

        public override void StartJump()
        {
            DecoratedPlayer.StartJump();
        }

        public override void EndJump()
        {
            DecoratedPlayer.EndJump();
        }
    }
}
