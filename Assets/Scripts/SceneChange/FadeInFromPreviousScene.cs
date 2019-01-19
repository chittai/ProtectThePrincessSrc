using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VRGame
{
    public class FadeInFromPreviousScene : MonoBehaviour
    {
        public GameObject forFadeCanvas;

        [SerializeField]
        private float _fadeSpeed = 0.05f;

        [SerializeField]
        private float _alphaValue = 1.0f;

        private void Awake()
        {
            this.FadeIn();
        }

        /// <summary>
        /// シーンチェンジ時にFadeInする処理
        /// </summary>
        public void FadeIn()
        {
            forFadeCanvas.SetActive(true);
            Image forFadePanel = forFadeCanvas.GetComponent<Image>();

            forFadePanel.color = new Color(0, 0, 0, 1);
            StartCoroutine(FadeInCoroutine(forFadePanel));
        }

        IEnumerator FadeInCoroutine(Image panel)
        {
            while (0 <= _alphaValue)
            {
                _alphaValue -= _fadeSpeed;
                panel.color = new Color(0, 0, 0, _alphaValue);

                yield return null;
            }
        }
    }
}