using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class AxisRotationDisabled : MonoBehaviour
    {

        private Quaternion _rotation;

        void Start()
        {
            _rotation = transform.localRotation;
        }

        void Update()
        {
            // キャラクターが横を向いてもライフポイントは常に前を向いたままにする
            transform.localRotation = Quaternion.AngleAxis(-transform.parent.eulerAngles.y, Vector3.up) * _rotation;
        }
    }
}