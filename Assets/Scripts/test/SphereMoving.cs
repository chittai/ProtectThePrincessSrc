using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chronos;

public class SphereMoving : MonoBehaviour
{


    [SerializeField] private float speed = 13;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
