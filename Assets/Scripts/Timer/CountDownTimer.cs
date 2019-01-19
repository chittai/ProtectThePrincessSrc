using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VRGame
{
    public class CountDownTimer : MonoBehaviour
    {

        public Text leftText;
        public Text rightText;
        private Text _timerText;

        public static int time { get; set; } = 35;

        private OVRInput.Controller controller;

        void Start()
        {
            controller = OVRInput.GetActiveController();
        }

        void Update()
        {
            // アクティブなコントローラを判定し、そのコントローラの子オブジェクトとして
            // 存在しているTextに時間を表示する
            controller = OVRInput.GetActiveController();
            _timerText = rightText;
            if (controller == OVRInput.Controller.RTrackedRemote)
            {
                _timerText = rightText;
            }
            else if (controller == OVRInput.Controller.LTrackedRemote)
            {
                _timerText = leftText;
            }
        }

        /// <summary>
        /// プレイ時間のタイマー
        /// </summary>
        public void StartTimer()
        {
            StartCoroutine(TimerCoroutine());
        }

        IEnumerator TimerCoroutine()
        {
            while (time >= 0)
            {
                _timerText.text = time.ToString();
                yield return new WaitForSeconds(1);
                Debug.Log(time);
                time--;
            }
        }
    }
}