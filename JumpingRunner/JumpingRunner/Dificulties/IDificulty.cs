using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner.Dificulties
{
    public interface IDificulty
    {
        void SetRespawnInterval(Timer timer);
    }
}
