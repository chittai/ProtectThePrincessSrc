using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

    public Text leftText;
    public Text rightText;

    private Text timerText;

    public static int time { get; set; }

    //public delegate void TimerEventHandler(int time, Text counterText);
    //public delegate void TimerEventHandler(int time);
    //public event TimerEventHandler OnTimeChanged;

    void Start()
    {

        time = 35;
    }


    void Update()
    {
        timerText = leftText;
        var controller = OVRInput.GetActiveController();

        if (controller == OVRInput.Controller.RTrackedRemote)
        {
            timerText = rightText;
        }
        else if (controller == OVRInput.Controller.LTrackedRemote)
        {
            timerText = leftText;
        }
    }

    public void StartTimer () {
        StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine()
    {
        while (time >= 0)
        {
            //OnTimeChanged(time);
            timerText.text = time.ToString();
            yield return new WaitForSeconds(1);
            time--;
        }
    }
}
