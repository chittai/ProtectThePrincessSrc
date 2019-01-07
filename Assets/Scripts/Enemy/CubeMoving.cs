using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chronos;

public class CubeMoving : MonoBehaviour {


    [SerializeField] private float speed = 13;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(0,0,1) * GetComponent<Timeline>().deltaTime * speed);

    }
}
