using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisRotationDisabled : MonoBehaviour {

    Quaternion m_rotation;

    void Start()
    {
        m_rotation = transform.localRotation;
    }

    void Update()
    {

        transform.localRotation = Quaternion.AngleAxis(-transform.parent.eulerAngles.y, Vector3.up) * m_rotation;
    }
}