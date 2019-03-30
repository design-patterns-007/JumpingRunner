using JumpingRunner.Obstacle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    public class Game
    {
        public Player Player { get; set; }
        public Background Background { get; set; }
        ObstacleFactory pitFactory { get; set; } = new PitFactory();
        Obstacle.Obstacle obstacle;

        public Game(Player player, Background background)
        {
            Player = player;
            Background = background;

            Point[] points = new Point[3];
            points[0] = new Point(620, 240);
            points[1] = new Point(600, 280);
            points[2] = new Point(640, 280);
            obstacle = pitFactory.GetObstacle(points, Color.Black);
        }

        public void Update()
        {
            Player.Update();
            obstacle.Update();
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            Background.Paint(sender, e);
            Player.Paint(sender, e);
            
            obstacle.Paint(sender, e);

        }

    }
}
