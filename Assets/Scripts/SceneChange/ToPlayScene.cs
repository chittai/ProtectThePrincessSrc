using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class ToPlayScene : MonoBehaviour
    {
        private FadeOutSceneChange fadeOutSceneChange;
        private PlaySoundEffect playSoundEffect;

        void Start()
        {
            fadeOutSceneChange = GetComponent<FadeOutSceneChange>();
            playSoundEffect = GetComponent<PlaySoundEffect>();
        }

        void Update()
        {

            /*
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                playSoundEffect.Sound();
                fadeOutSceneChange.SceneChange("Play_Master");
            }
            */

            // for Debug
            /*
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playSoundEffect.Sound();
                fadeOutSceneChange.SceneChange("Play_Master");
            }
            */
        }
    }
}