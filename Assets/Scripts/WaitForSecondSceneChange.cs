using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitForSecondSceneChange : MonoBehaviour {

    [SerializeField]
    private int second = 4;

    public void SceneChange(string sceneName)
    {
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
