using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chronos;

namespace VRGame
{
    public class ChangeEmissionColor : MonoBehaviour
    {

        private Timeline _time;

        void Start()
        {
            _time = GetComponent<Timeline>();
        }

        void Update()
        {

            if (_time.timeScale < 1)
            {
                Renderer renderer = GetComponent<Renderer>();
                renderer.material.EnableKeyword("_EMISSION");
                renderer.material.SetColor("_EmissionColor", new Color(1, 0, 0));
            }
        }
    }
}
