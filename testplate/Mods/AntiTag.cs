using System;
using System.Collections.Generic;
using System.Text;

namespace Holographic.Mods
{
    internal class AntiTag
    {
        public static void AntiTagMod()
        {
            if (GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected"))
            {
                return;
            }
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig.mainSkin.material.name.Contains("fected") && UnityEngine.Vector3.Distance(vrrig.transform.position, GorillaTagger.Instance.offlineVRRig.transform.position) <= 7f)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.position = GorillaLocomotion.Player.Instance.transform.position - new UnityEngine.Vector3(0f, 7f, 0f);
                }
            }
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }
    }
}
