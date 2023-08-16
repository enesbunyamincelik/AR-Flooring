using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ChangeGridTex : MonoBehaviour
{
    public Texture planeTex;
    public ARPlaneManager arPlaneManager;
    public void ChangeGridTexture()
    {
        foreach (ARPlane plane in arPlaneManager.trackables)
        {
            plane.gameObject.GetComponent<MeshRenderer>().materials[0].mainTexture = planeTex;
        }
    }
}