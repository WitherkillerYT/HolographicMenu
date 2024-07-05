using System;
using System.Collections.Generic;
using System.Text;

namespace Holographic.Mods
{
    internal class SlideControl
    {
        public static void SlideControlMod()
        {
            GorillaLocomotion.Player.Instance.slideControl = 0.5f;
        }
    }
}
