using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Holographic.Mods
{
    internal class ghost
    {
        
        public static void GhostMonkeMod()
        {
            bool GhostButton = ControllerInputPoller.instance.rightControllerPrimaryButton;
            if (GhostButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GameObject gameObject = GameObject.CreatePrimitive(0);
                UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(gameObject.GetComponent<SphereCollider>());
                gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                gameObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                gameObject.GetComponent<Renderer>().material.color = new Color32(56, 255, 244, 251);
                GameObject gameObject2 = GameObject.CreatePrimitive(0);
                UnityEngine.Object.Destroy(gameObject2.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(gameObject2.GetComponent<SphereCollider>());
                gameObject2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                gameObject2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                gameObject2.GetComponent<Renderer>().material.color = new Color32(56, 255, 244, 251);
                UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                UnityEngine.Object.Destroy(gameObject2, Time.deltaTime);
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}
    

