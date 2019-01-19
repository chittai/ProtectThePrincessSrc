using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class ToMenuScene : MonoBehaviour
    {
        private FadeOutSceneChange _fadeOutSceneChange;

        void Start()
        {
            _fadeOutSceneChange = GetComponent<FadeOutSceneChange>();
        }

        void Update()
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                _fadeOutSceneChange.SceneChange("Select_Master");
            }

            // for Debug
            /*
            if (Input.GetKeyDown(KeyCode.Space))
            {
                fadeOutSceneChange.SceneChange("Select_Master");
            }
            */

        }
    }
}