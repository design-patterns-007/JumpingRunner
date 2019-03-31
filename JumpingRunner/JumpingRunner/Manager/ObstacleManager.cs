using JumpingRunner.Difficulties;
using JumpingRunner.Obstacles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner.Manager
{
    public class ObstacleManager
    {
        public List<Obstacle> Obstacles { get; set; }
        public Timer Timer;
        private ObstacleFactoryBridge _obstacleFactoryBridge;
        private Random _random;

        public ObstacleManager()
        {
            Obstacles = new List<Obstacle>();
            Timer = new Timer();
            _obstacleFactoryBridge = new ObstacleFactoryBridge();
            _random = new Random();

            Timer.Interval = 1300;
            Timer.Tick += TimerTick;
            Timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Random random = new Random();
            int result = random.Next(2);
            ObstacleFactory factory = null;

            if (result==1) {
                factory = new SpikeFactory();                                
            } else{
                factory = new PitFactory();
            } 
            Obstacles.Add(factory.GetObstacle());
            int factoryIndex = _random.Next(ObstacleFactoryBridge.NumberOfFactories);
            Obstacles.Add(_obstacleFactoryBridge.SpawnObstacle(factoryIndex));

        }

        public void Update()
        {
            foreach(Obstacle obstacle in Obstacles) {
                obstacle.Update();
            }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            foreach(Obstacle obstacle in Obstacles) {
                obstacle.Paint(sender, e);
            }
        }
    }
}
