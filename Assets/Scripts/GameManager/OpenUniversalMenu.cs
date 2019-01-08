using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class OpenUniversalMenu : MonoBehaviour
    {
        void Update()
        {
            // "←"ボタンを押した時にメニュー画面を開く処理
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OVRManager.PlatformUIConfirmQuit();
            }
        }
    }
}