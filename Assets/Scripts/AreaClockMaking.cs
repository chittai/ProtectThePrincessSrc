using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaClockMaking : MonoBehaviour {

    public GameObject areaClock;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) && GetComponent<GuageDecreasing>().restGuage >= 0)
        {
            areaClock.SetActive(true);
            GetComponent<GuageDecreasing>().Decreasing();
        }
        else
        {
            areaClock.SetActive(false);
        }

        // for Debug
        /*
        Debug.Log(GetComponent<GuageDecreasing>().restGuage);
        if (Input.GetKey(KeyCode.Space))
        {
            areaClock.SetActive(true);
            GetComponent<GuageDecreasing>().Decreasing();
        }
        else
        {
            //Debug.Log("test");
            areaClock.SetActive(false);
        }
        */
        
    }
}
