using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour {

    [SerializeField] private CountDownTimer countDownTimer;
    [SerializeField] private Text counterText;

    // Use this for initialization
    void Awake() {
        //countDownTimer.OnTimeChanged += time =>
        //{
        //    counterText.text = time.ToString();
        //};
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
