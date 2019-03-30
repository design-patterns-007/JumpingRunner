using JumpingRunner.Obstacles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingRunner.Observers
{
    class CollisionObserver : Observer
    {
        public CollisionObserver(Game game) : base(game)
        {
        }

        public override void Update()
        {
            foreach(Obstacle obstacle in Game.ObstacleManager.Obstacles) {
                if (PlayerInObstacle(Game.Player, obstacle)) {
                    Game.Player.IsAlive = false;
                    return;
                }
            }
        }

        private bool PlayerInObstacle(Player player, Obstacle obstacle)
        {
            PointF bottomRight = new PointF(player.Shape.X, player.Shape.Y+player.Shape.Height);
            PointF bottomLeft = new PointF(player.Shape.X+player.Shape.Width, player.Shape.Y + player.Shape.Height);
            
            return IsPointInPolygon(obstacle.Points, bottomRight) || IsPointInPolygon(obstacle.Points, bottomLeft);
        }

        public static bool IsPointInPolygon(PointF[] polygon, PointF testPoint)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++) {
                if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y) {
                    if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X) {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
    }
}
