using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMaking : MonoBehaviour {

    public GameObject startPoint;
    public GameObject endPoint;

    void Start () {
        LineRenderer linerenderer = GetComponent<LineRenderer>();

        linerenderer.startWidth = 0.01f;
        linerenderer.endWidth = 0.01f;

        linerenderer.positionCount = 2;

        linerenderer.startColor = Color.red;
        linerenderer.endColor = Color.red; 

        //linerenderer.SetColors(Color.blue, Color.red);

        linerenderer.SetPosition(0, startPoint.transform.position);
        linerenderer.SetPosition(1, endPoint.transform.position);

    }
}
