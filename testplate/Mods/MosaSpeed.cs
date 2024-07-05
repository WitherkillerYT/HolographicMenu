using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class MosaSpeed
    {
        public static void MosaSpeedMod()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 5.2f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 3.1f;
        }
    }
}
