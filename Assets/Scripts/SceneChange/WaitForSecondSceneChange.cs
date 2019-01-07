using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitForSecondSceneChange : MonoBehaviour {

    /// <summary>
    /// 指定した秒数後にシーンチェンジする
    /// </summary>
    /// <param name="sceneName">遷移先のシーン名</param>
    public void SceneChange(string sceneName)
    {
        var second = 4;
        StartCoroutine(WaitForSecondCoroutine(second, sceneName));
    }

    IEnumerator WaitForSecondCoroutine(int second, string sceneName)
    {
        for (int i = 0; i < second; i++)
        {
            yield return new WaitForSeconds(1);
        }
        SceneManager.LoadScene(sceneName);
    }
}
