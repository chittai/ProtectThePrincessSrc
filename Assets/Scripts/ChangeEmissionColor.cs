using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chronos;

public class ChangeEmissionColor : MonoBehaviour {

    Timeline time;

	// Use this for initialization
	void Start () {
        time = GetComponent<Timeline>();
	}
	
	// Update is called once per frame
	void Update () {

        if (time.timeScale < 1)
        {
            Renderer r = GetComponent<Renderer>();
            r.material.EnableKeyword("_EMISSION");
            r.material.SetColor("_EmissionColor",new Color(1,0,0));
        }
	}
}
