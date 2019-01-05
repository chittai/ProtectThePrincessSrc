using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlayScene : MonoBehaviour {

    private bool isAlreadyPush;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space) && !isAlreadyPush)
        {
            LoadPlayScene();
        }

        if (!FadeInOut.isNowFadeOut)
        {
            SceneManager.LoadScene("Play_Master");
        }
    }

    public void LoadPlayScene()
    {
        GetComponent<PlaySoundEffect>().Sound();
        GetComponent<FadeInOut>().FadeOut();
    }
}
