using System;
using System.Collections.Generic;
using System.Text;

namespace Holographic.Mods
{
    internal class LongArms
    {
        public static void LongArmsMod()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new UnityEngine.Vector3(1.3f, 1.3f, 1.3f);
        }
    }
}
