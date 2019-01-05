using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSelectScene : MonoBehaviour {

    private bool isAlreadyPush;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) && !isAlreadyPush)
        {
            GetComponent<FadeInOut>().FadeOut();
            isAlreadyPush = true;
        } else if (isAlreadyPush && !FadeInOut.isNowFadeOut)
        {
            SceneManager.LoadScene("Select_Master");
        }

        // for Debug
        /*
        if (Input.GetKeyDown(KeyCode.Space) && !isAlreadyPush)
        {
            GetComponent<FadeInOut>().FadeOut();
            isAlreadyPush = true;
        }
        else if (isAlreadyPush && !FadeInOut.isNowFadeOut)
        {
            SceneManager.LoadScene("Select_Master");
        }
        */
    }
}
