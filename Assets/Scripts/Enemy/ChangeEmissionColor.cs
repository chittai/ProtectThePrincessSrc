using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chronos;

public class ChangeEmissionColor : MonoBehaviour {

    Timeline time;

	void Start () {
        time = GetComponent<Timeline>();
	}
	
	void Update () {

        if (time.timeScale < 1)
        {
            Renderer r = GetComponent<Renderer>();
            r.material.EnableKeyword("_EMISSION");
            r.material.SetColor("_EmissionColor",new Color(1,0,0));
        }
	}
}
