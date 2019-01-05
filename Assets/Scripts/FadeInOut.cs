using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeInOut : MonoBehaviour {

    public static bool isNowFadeIn { get; set; }
    public static bool isNowFadeOut { get;set;}

    public GameObject forFadeCanvas;
    
    private float alpha;
    private float fadeSpeed;

    // Use this for initialization
    void Start () {
        isNowFadeIn = true;
        isNowFadeOut = true;
        //forFadeCanvas.SetActive(false);
    }

    public void FadeIn()
    {
        forFadeCanvas.SetActive(true); 
        Image forFadePanel = forFadeCanvas.GetComponent<Image>();

        forFadePanel.color = new Color(0, 0, 0, 1);
        StartCoroutine(FadeInCoroutine(forFadePanel));
    }

    public void FadeOut()
    {
        forFadeCanvas.SetActive(true);
        Image forFadePanel = forFadeCanvas.GetComponent<Image>();

        forFadePanel.color = new Color(0, 0, 0, 0);
        StartCoroutine(FadeOutCoroutine(forFadePanel));
    }

    IEnumerator FadeInCoroutine(Image panel)
    {
        alpha = 1.0f;
        fadeSpeed = 0.05f;

        isNowFadeIn = true;

        while (0 <= alpha)
        {
            alpha -= fadeSpeed;
            panel.color = new Color(0, 0, 0, alpha);

            yield return null;
        }
        isNowFadeIn = false;
    }

    IEnumerator FadeOutCoroutine(Image panel)
    {
        alpha = 0f;
        fadeSpeed = 0.05f;

        isNowFadeOut = true;

        while (alpha < 1)
        {
            alpha += fadeSpeed;
            panel.color = new Color(0, 0, 0, alpha);

            yield return null;
        }
        isNowFadeOut = false;
    }

}
