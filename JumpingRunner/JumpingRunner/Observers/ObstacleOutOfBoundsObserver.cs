using JumpingRunner.Obstacles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingRunner.Observers
{
    class ObstacleOutOfBoundsObserver : Observer
    {
        public ObstacleOutOfBoundsObserver(Game game) : base(game)
        {
        }

        public override void Update()
        {
            if (Game.ObstacleManager.Obstacles.Count > 0) {
                Obstacle obstacle = Game.ObstacleManager.Obstacles.First();
                float maxXCoord = MaxXCoord(obstacle);

                if (maxXCoord < 0) {
                    Game.ObstacleManager.Obstacles.Remove(obstacle);
                }
            }
        }

        private float MaxXCoord(Obstacle obstacle)
        {
            float maxValue = float.MinValue;

            foreach (PointF point in obstacle.Points) {
                if (maxValue < point.X) {
                    maxValue = point.X;
                }
            }
            return maxValue;
        }
    }
}
