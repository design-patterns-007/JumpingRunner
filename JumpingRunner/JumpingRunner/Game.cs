using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    public class Game
    {
        public Player Player { get; set; }

        public Game(Player player)
        {
            Player = player;
        }

        public void Update()
        {
            Player.Update();
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            Player.Paint(sender, e);
        }

    }
}
