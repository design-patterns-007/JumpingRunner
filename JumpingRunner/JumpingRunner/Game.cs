using JumpingRunner.Obstacles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JumpingRunner.Observers;

namespace JumpingRunner
{
    public class Game
    {
        public Player Player { get; set; }
        public Background Background { get; set; }

        ObstacleFactory pitFactory { get; set; } = new PitFactory();
        Obstacle obstacle;

        public List<Obstacle> Obstacles { get; set; }
        public List<Observer> Observers { get; set; }

        public Game(Player player, Background background)
        {
            Player = player;
            Background = background;

            PointF[] points = new PointF[3];
            points[0] = new PointF(620, 240);
            points[1] = new PointF(600, 280);
            points[2] = new PointF(640, 280);
            obstacle = pitFactory.GetObstacle(points, Color.Black);
        
            Obstacles = new List<Obstacle>();
            Observers = new List<Observer>();

            Obstacles.Add(obstacle);

            Observer collissionObserver = new CollisionObserver(this);

        }

        public void Update()
        {
            Player.Update();
            obstacle.Update();
            NotifyObservers();
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            Background.Paint(sender, e);
            Player.Paint(sender, e);
            
            obstacle.Paint(sender, e);

        }

        internal void AttachObserver(Observer observer)
        {
            Observers.Add(observer);
        }

        private void NotifyObservers()
        {
            foreach(Observer ob in Observers) {
                ob.Update();
            }
        }

    }
}
