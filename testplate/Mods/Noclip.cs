﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Holographic.Mods
{
    internal class Noclip
    {
        public static void NoClipV1()
        {
            bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;
            if (flag)
            {
                foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    meshCollider.enabled = false;
                }
            }
            else
            {
                foreach (MeshCollider meshCollider2 in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    meshCollider2.enabled = true;
                }
            }
        }
    }
}
