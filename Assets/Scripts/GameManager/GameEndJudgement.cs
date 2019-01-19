using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class GameEndJudgement : MonoBehaviour
    {
        private bool _isOver;

        void Start()
        {
            _isOver = false;
        }

        void Update()
        {

            if (HpDecreasing.hp < 0 && !_isOver)
            {
                GetComponent<GameOver>().GameEndDetail();
                _isOver = true;
            }
            else if (CountDownTimer.time <= 0 && HpDecreasing.hp >= 0 && !_isOver)
            {
                GetComponent<GameClear>().GameEndDetail();
                _isOver = true;
            }
        }
    }
}