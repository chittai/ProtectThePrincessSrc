using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class BlendShapeChange : MonoBehaviour {

    private VRMBlendShapeProxy proxy;
    public bool clearFlag;
    public bool selectSceneFlag;


    // Use this for initialization
    void Update () {

        if (clearFlag)
        {
            proxy = GetComponent<VRMBlendShapeProxy>();
            proxy.SetValue(BlendShapePreset.Joy, 1.0f);

            Debug.Log(proxy);

        }
        else if (!clearFlag && !selectSceneFlag)
        {
            proxy = GetComponent<VRMBlendShapeProxy>();
            proxy.SetValue("BLENDSHAPECLIP.VERYSORROW", 1.0f);
        }
        else
        {
            
        }
    }
}
