using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Holographic.Mods
{
    internal class Fly
    {
        public static void FlyMod()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += (GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        } 
    }
}
