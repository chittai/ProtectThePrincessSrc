using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOutSceneChange : MonoBehaviour
{
    public GameObject forFadeCanvas;

    private float alphaValue;
    private float fadeSpeed;

    public void SceneChange(string sceneName)
    {
        forFadeCanvas.SetActive(true);
        Image forFadePanel = forFadeCanvas.GetComponent<Image>();
        forFadePanel.color = new Color(0, 0, 0, 0);

        StartCoroutine(FadeOutCoroutine(forFadePanel, sceneName));
    }


    IEnumerator FadeOutCoroutine(Image fadePanel,string sceneName)
    {
        alphaValue = 0f;
        fadeSpeed = 0.05f;
        
        while (alphaValue < 1)
        {
            alphaValue += fadeSpeed;
            fadePanel.color = new Color(0, 0, 0, alphaValue);

            yield return null;
        }

        SceneManager.LoadScene(sceneName);

    }
}
