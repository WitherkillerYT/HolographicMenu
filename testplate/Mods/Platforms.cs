﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Holographic.Mods
{
    internal class Platforms
    {
        private static GameObject leftplat = null;
        private static GameObject rightplat = null;

        private static GameObject CreatePlatformOnHand(Transform handTransform)
        {
            GameObject plat = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            plat.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

            plat.transform.position = handTransform.position;
            plat.transform.rotation = handTransform.rotation;

            float h = (Time.frameCount / 180f) % 1f;
            plat.GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
            return plat;
        }


        public static void PlatformsMod()
        {
            if (ControllerInputPoller.instance.leftGrab && leftplat == null)
            {
                leftplat = CreatePlatformOnHand(GorillaTagger.Instance.leftHandTransform);
            }

            if (ControllerInputPoller.instance.rightGrab && rightplat == null)
            {
                rightplat = CreatePlatformOnHand(GorillaTagger.Instance.rightHandTransform);
            }

            if (ControllerInputPoller.instance.rightGrabRelease && rightplat != null)
            {
                rightplat.Disable();
                rightplat = null;
            }

            if (ControllerInputPoller.instance.leftGrabRelease && leftplat != null)
            {
                leftplat.Disable();
                leftplat = null;
            }
        }
    }
}
