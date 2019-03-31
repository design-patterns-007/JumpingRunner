using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner.Dificulties
{
    public class HardDificulty : IDificulty
    {
        public void SetRespawnInterval(Timer timer)
        {
            timer.Interval = 1200;
        }
    }
}
