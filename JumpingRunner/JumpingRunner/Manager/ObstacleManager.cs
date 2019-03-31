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
<<<<<<< HEAD
        private Timer _timer;
=======
        public Timer Timer;
        private ObstacleFactoryBridge _obstacleFactoryBridge;
        private Random _random;
>>>>>>> d3464a4aab3c8308035d0d64e181f851358060e1

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
<<<<<<< HEAD
            Random random = new Random();
            int result = random.Next(2);
            ObstacleFactory factory = null;

            if (result==1) {
                factory = new SpikeFactory();                                
            } else{
                factory = new PitFactory();
            } 
            Obstacles.Add(factory.GetObstacle());
=======
            int factoryIndex = _random.Next(ObstacleFactoryBridge.NumberOfFactories);
            Obstacles.Add(_obstacleFactoryBridge.SpawnObstacle(factoryIndex));
>>>>>>> d3464a4aab3c8308035d0d64e181f851358060e1
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
