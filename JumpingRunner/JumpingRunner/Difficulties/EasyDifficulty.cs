using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner.Difficulties
{
    public class EasyDifficulty : IDifficulty
    {
        public Timer GetRespawnInterval(Timer timer)
        {
            timer.Interval = 1500;
            return timer;
        }
    }
}
