using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class LineMaking : MonoBehaviour
    {
        public GameObject startPoint;
        public GameObject endPoint;

        void Start()
        {

            //敵の攻撃の始点(発生位置)と終点(目標座標)で線を結ぶ
            LineRenderer linerenderer = GetComponent<LineRenderer>();

            linerenderer.startWidth = 0.01f;
            linerenderer.endWidth = 0.01f;

            linerenderer.positionCount = 2;

            linerenderer.startColor = Color.red;
            linerenderer.endColor = Color.red;

            linerenderer.SetPosition(0, startPoint.transform.position);
            linerenderer.SetPosition(1, endPoint.transform.position);

        }
    }
}