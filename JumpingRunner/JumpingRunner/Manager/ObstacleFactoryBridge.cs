using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JumpingRunner.Obstacles;

namespace JumpingRunner.Manager
{
    class ObstacleFactoryBridge : IObstacleBridge
    {
        private ObstacleFactory _obstacleFactory { get; set; }
        public static int NumberOfFactories = 2;
        public Obstacle SpawnObstacle(int value)
        {
            if (value == NumberOfFactories) {
                throw new Exception("Bad index");
            }

            Obstacle obstacle = null;
            switch (value) {
                case 0: {
                        _obstacleFactory = new SpikeFactory();
                        obstacle = _obstacleFactory.GetObstacle();
                        break;
                    }
                case 1: {
                        _obstacleFactory = new PitFactory();
                        obstacle = _obstacleFactory.GetObstacle();
                        break;
                    }
            }

            return obstacle;
        }
    }
}