using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chronos;

namespace VRGame
{
    public class CubeMoving : MonoBehaviour
    {

        [SerializeField] private float speed = 13;

        private Timeline timeLine;

        void Start()
        {
            timeLine = GetComponent<Timeline>();
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.Translate(new Vector3(0, 0, 1) * timeLine.deltaTime * speed);
        }
    }
}