using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class SlowMotionEffectMaking : MonoBehaviour {

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            GetComponent<PostProcessingBehaviour>().enabled = true;
        }
        else
        {
            GetComponent<PostProcessingBehaviour>().enabled = false;
        }
    }
}
