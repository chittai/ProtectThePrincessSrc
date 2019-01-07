using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUniversalMenu : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OVRManager.PlatformUIConfirmQuit();
        }
    }
}
