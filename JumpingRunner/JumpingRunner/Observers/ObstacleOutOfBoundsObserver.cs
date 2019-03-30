using JumpingRunner.Obstacles;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        private bool checkIfOutOfBounds(Obstacle obstacle)
        {
            return false;
        }
    }
}
