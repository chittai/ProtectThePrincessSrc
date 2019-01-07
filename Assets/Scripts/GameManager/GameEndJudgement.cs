using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndJudgement : MonoBehaviour {

    private bool isOver;

	// Use this for initialization
	void Start () {
        isOver = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (HpDecreasing.hp < 0 && !isOver)
        {
            GetComponent<GameOver>().GameEndDetail();
            isOver = true;
        }
        else if(CountDownTimer.time <= 0 && HpDecreasing.hp >= 0 && !isOver)
        {
            GetComponent<GameClear>().GameEndDetail();
            isOver = true;
        }
	}
}
