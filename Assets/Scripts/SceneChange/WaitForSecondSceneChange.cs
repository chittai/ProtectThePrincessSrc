using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitForSecondSceneChange : MonoBehaviour {

    public void SceneChange(string sceneName)
    {
        var second = 4;
        StartCoroutine(WaitForSecondCoroutine(second, sceneName));
    }

    IEnumerator WaitForSecondCoroutine(int second, string sceneName)
    {
        Debug.Log("second : " + second);
        for (int i = 0; i < second; i++)
        {

            yield return new WaitForSeconds(1);
        }
        SceneManager.LoadScene(sceneName);
    }
}
