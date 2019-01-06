using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFromPreviousScene : MonoBehaviour
{

    public GameObject forFadeCanvas;

    private float fadeSpeed;
    private float alpha;

    private void Awake()
    {
        this.FadeIn();
    }

    public void FadeIn()
    {
        forFadeCanvas.SetActive(true);
        Image forFadePanel = forFadeCanvas.GetComponent<Image>();

        forFadePanel.color = new Color(0, 0, 0, 1);
        StartCoroutine(FadeInCoroutine(forFadePanel));
    }

    IEnumerator FadeInCoroutine(Image panel)
    {
        alpha = 1.0f;
        fadeSpeed = 0.05f;

        while (0 <= alpha)
        {
            alpha -= fadeSpeed;
            panel.color = new Color(0, 0, 0, alpha);

            yield return null;
        }
    }
}