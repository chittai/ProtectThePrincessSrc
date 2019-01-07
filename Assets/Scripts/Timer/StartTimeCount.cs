using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTimeCount : MonoBehaviour {

    public Text starTimerText;
    public GameObject playTimer;
    public GameObject enemyGroup;

    void Start () {
        StartCoroutine(PlayStarCountCoroutine());
	}
	
    /// <summary>
    /// シーンチェンジ後にゲーム開始までのカウントダウンを行う。
    /// カウントダウン後には"START"を表示する。
    /// </summary>
    /// <returns></returns>
    IEnumerator PlayStarCountCoroutine()
    {
        var time = 3;
        while (time >= 0)
        {
            if (time == 0)
            {
                starTimerText.text = "START";
                transform.GetChild(2).GetComponent<PlaySoundEffect>().Sound();
            }
            else
            {
                transform.GetChild(1).GetComponent<PlaySoundEffect>().Sound();
                starTimerText.text = time.ToString();
            }
            yield return new WaitForSeconds(1);
            time--;
        }

        starTimerText.enabled = false;

        foreach (Transform enemy in enemyGroup.transform)
        {
            enemy.GetComponent<EnemyMoving>().enabled = true;
            enemy.GetComponent<CubeMaking>().enabled = true;
        }

        playTimer.GetComponent<CountDownTimer>().StartTimer();
        transform.GetChild(3).GetComponent<PlaySoundEffect>().Sound();

    }

}
