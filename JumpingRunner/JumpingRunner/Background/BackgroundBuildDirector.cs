using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    class BackgroundBuildDirector
    {
        IBackgroundBuilder backgroundBuilder;

        public BackgroundBuildDirector(IBackgroundBuilder iBackgroundBuilder)
        {
            backgroundBuilder = iBackgroundBuilder;
        }

        public void Construct(EStageStyle stageStyle)
        {
            switch(stageStyle)
            {
                case EStageStyle.DESERT:
                    {
                        backgroundBuilder.SetFloorColor(Color.Orange);
                        backgroundBuilder.SetSkyColor(Color.Gold);
                        break;
                    }
                case EStageStyle.JUNGLE:
                    {
                        backgroundBuilder.SetFloorColor(Color.Sienna);
                        backgroundBuilder.SetSkyColor(Color.ForestGreen);
                        break;
                    }
                case EStageStyle.ICE:
                    {
                        backgroundBuilder.SetFloorColor(Color.LightCyan);
                        backgroundBuilder.SetSkyColor(Color.LightSkyBlue);
                        break;
                    }
            }
        }
        
        public Background GetBackground()
        {
            return backgroundBuilder.GetBackground();
        }
    }
}
