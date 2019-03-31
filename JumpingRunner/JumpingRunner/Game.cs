using JumpingRunner.Obstacles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JumpingRunner.Observers;
using JumpingRunner.Manager;
using JumpingRunner.Difficulties;

namespace JumpingRunner
{
    public class Game
    {
        public Player Player { get; set; }
        public Background Background { get; set; }

        public ObstacleManager ObstacleManager { get; set; }
        public List<Observer> Observers { get; set; }

        public IDifficulty dificulty = new ImposibleDifficulty();

        public Game(Player player, Background background)
        {
            Player = player;
            Background = background;
           
            ObstacleManager = new ObstacleManager();
            ObstacleManager._timer = dificulty.GetRespawnInterval(ObstacleManager._timer);

            Observers = new List<Observer>();
            Observer collissionObserver = new CollisionObserver(this);
            Observer outOfBoundsObserver = new ObstacleOutOfBoundsObserver(this);
        }

        public void Update()
        {
            Player.Update();
            ObstacleManager.Update();
            
            NotifyObservers();            
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            Background.Paint(sender, e);
            Player.Paint(sender, e);

            ObstacleManager.Paint(sender, e);
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
