using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Holographic.Mods
{
    internal class AntiReport
    {
        public static void Antireportdisconnect()
        {
            foreach (GorillaPlayerScoreboardLine allScoreboardLine in GorillaScoreboardTotalUpdater.allScoreboardLines)
            {
                if (allScoreboardLine.linePlayer == NetworkSystem.Instance.LocalPlayer)
                {
                    Transform transform = ((Component)allScoreboardLine.reportButton).gameObject.transform;
                    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                    {
                        if (vrrig.gameObject != GorillaTagger.Instance.offlineVRRig.gameObject)
                        {
                            float righthand = Vector3.Distance(vrrig.rightHandTransform.position, transform.position);
                            float lefthand = Vector3.Distance(vrrig.leftHandTransform.position, transform.position);
                            float distance = 0.85f;
                            if (righthand <= distance || lefthand <= distance)
                            {
                                PhotonNetwork.Disconnect();
                            }
                        }
                    }
                }
            }
        }
    }
}

