using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMenuScene : MonoBehaviour
{
    private FadeOutSceneChange fadeOutSceneChange;

    void Start()
    {
        fadeOutSceneChange = GetComponent<FadeOutSceneChange>();
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            fadeOutSceneChange.SceneChange("Select_Master");
        }

        // for Debug
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fadeOutSceneChange.SceneChange("Select_Master");
        }
        
    }
}