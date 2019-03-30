using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingRunner.Observers
{
    public abstract class Observer
    {
        public Game Game { get; set; }

        public Observer(Game game)
        {
            Game = game;
            Game.AttachObserver(this);
        }

        public abstract void Update();
    }
}
