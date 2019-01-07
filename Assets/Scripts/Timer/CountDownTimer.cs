using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

    public Text leftText;
    public Text rightText;
    private Text timerText;

    public static int time { get; set; }

    private OVRInput.Controller controller;

    void Start()
    {
        controller = OVRInput.GetActiveController();
        time = 35;
    }

    void Update()
    {
        // アクティブなコントローラを判定し、そのコントローラの子オブジェクトとして
        // 存在しているTextに時間を表示する
        controller = OVRInput.GetActiveController();

        if (controller == OVRInput.Controller.RTrackedRemote)
        {
            timerText = rightText;
        }
        else if (controller == OVRInput.Controller.LTrackedRemote)
        {
            timerText = leftText;
        }
    }

    /// <summary>
    /// プレイ時間のタイマー
    /// </summary>
    public void StartTimer () {
        StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine()
    {
        while (time >= 0)
        {
            Debug.Log(timerText.text);
            timerText.text = time.ToString();
            yield return new WaitForSeconds(1);
            time--;
        }
    }
}
