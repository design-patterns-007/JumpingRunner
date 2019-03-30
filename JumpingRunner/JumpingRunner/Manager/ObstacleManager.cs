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
        private Timer _timer;

        public ObstacleManager()
        {
            Obstacles = new List<Obstacle>();
            _timer = new Timer();
            _timer.Interval = 1300;
            _timer.Tick += TimerTick;
            _timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Random random = new Random();
            int result= random.Next(2);
            ObstacleFactory factory = null;

            if (result==1) {
                factory = new SpikeFactory();                                
            } else{
                factory = new PitFactory();
            } 
            Obstacles.Add(factory.GetObstacle());
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
