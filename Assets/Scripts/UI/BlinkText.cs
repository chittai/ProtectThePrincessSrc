using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VRGame
{
    public class BlinkText : MonoBehaviour
    {

        public Text text;
        private float _blinkTime;

        // Use this for initialization
        void Start()
        {
            _blinkTime = Mathf.Clamp01(_blinkTime);
        }

        // Update is called once per frame
        void Update()
        {

            text.color = new Color(1, 1, 1, Mathf.PingPong(Time.time, 1));
        }
    }
}