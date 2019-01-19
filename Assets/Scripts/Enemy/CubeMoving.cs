using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chronos;

namespace VRGame
{
    public class CubeMoving : MonoBehaviour
    {

        [SerializeField]
        private float _speed = 13;

        private Timeline _timeLine;

        void Start()
        {
            _timeLine = GetComponent<Timeline>();
        }

        void Update()
        {
            this.transform.Translate(new Vector3(0, 0, 1) * _timeLine.deltaTime * _speed);
        }
    }
}