using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner.Difficulties
{
    public class ImposibleDifficulty : IDifficulty
    {
        public Timer GetRespawnInterval(Timer timer)
        {
            timer.Interval = 800;
            return timer;
        }
    }
}
