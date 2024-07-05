using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;
using UnityEngine;
using System.Diagnostics;

namespace Holographic.Mods
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + "(),nq}")]
    internal class TagGun
    {
        private static bool rightGrab;

        public static void TagGunMod()
        {
            if (!rightGrab && !Mouse.current.rightButton.isPressed)
            {
                return;
            }
            var GunData = RenderGun();
            RaycastHit Ray = (RaycastHit)GunData;
        }

        private static RaycastHit RenderGun()
        {
            throw new NotImplementedException();
        }

        private static object DebuggerDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
