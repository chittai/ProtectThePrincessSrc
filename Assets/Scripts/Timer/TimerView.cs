using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour {

    [SerializeField] private CountDownTimer _countDownTimer;
    [SerializeField] private Text _counterText;

    // Use this for initialization
    /*
    void Awake() {
        _countDownTimer.OnTimeChanged += time =>
        {
            _counterText.text = time.ToString();
        };
	}
    */
}
