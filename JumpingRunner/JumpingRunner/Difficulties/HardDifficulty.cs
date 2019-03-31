using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner.Difficulties
{
    public class HardDifficulty : IDifficulty
    {
        public Timer GetRespawnInterval(Timer timer)
        {
            timer.Interval = 1300;
            return timer;
        }
    }
}
