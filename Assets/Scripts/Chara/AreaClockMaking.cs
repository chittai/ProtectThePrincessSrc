using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaClockMaking : MonoBehaviour {

    public GameObject areaClock;
    private GuageDecreasing _guageDecreasing;

    void Start () {
        _guageDecreasing = GetComponent<GuageDecreasing>();
    }
	
	void Update () {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) && _guageDecreasing.restGuage >= 0)
        {
            areaClock.SetActive(true);
            _guageDecreasing.Decreasing();
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
