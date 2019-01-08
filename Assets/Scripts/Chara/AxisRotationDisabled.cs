using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class AxisRotationDisabled : MonoBehaviour
    {

        Quaternion m_rotation;

        void Start()
        {
            m_rotation = transform.localRotation;
        }

        void Update()
        {
            // キャラクターが横を向いてもライフポイントは常に前を向いたままにする
            transform.localRotation = Quaternion.AngleAxis(-transform.parent.eulerAngles.y, Vector3.up) * m_rotation;
        }
    }
}