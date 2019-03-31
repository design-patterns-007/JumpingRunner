using JumpingRunner.Obstacles;

namespace JumpingRunner.Manager
{
    public interface IObstacleBridge
    {
         Obstacle SpawnObstacle(int value);
    }
}
