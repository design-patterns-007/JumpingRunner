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

        public IDifficulty Difficulty { get; set; }
        public bool IsGameOver { get; private set; }

        public Game(Player player, Background background, IDifficulty difficulty)
        {
            Player = player;
            Background = background;
           
            ObstacleManager = new ObstacleManager();
            Difficulty = difficulty;
          
            ObstacleManager.Timer = Difficulty.GetRespawnInterval(ObstacleManager.Timer);
            Observers = new List<Observer>();
            Observer collissionObserver = new CollisionObserver(this);
            Observer outOfBoundsObserver = new ObstacleOutOfBoundsObserver(this);

            IsGameOver = false;
        }

        public void Start()
        {
            ObstacleManager.Timer.Start();
        }

        public void Stop()
        {
            ObstacleManager.Timer.Stop();
        }

        public void Update()
        {
            Player.Update();
            ObstacleManager.Update();
            
            NotifyObservers();
            if (!Player.IsAlive) {
                IsGameOver = true;
            }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            Background.Paint(sender, e);
            ObstacleManager.Paint(sender, e);
            Player.Paint(sender, e);

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
