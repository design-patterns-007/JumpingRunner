﻿using JumpingRunner.Obstacles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingRunner.Manager
{
    interface IObstacleBridge
    {
        Obstacle SpawnObstacle(int value);
    }
}
