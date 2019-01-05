using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromPreviousScene : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        GetComponent<FadeInOut>().FadeIn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
