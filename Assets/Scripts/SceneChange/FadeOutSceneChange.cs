using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace VRGame
{
    public class FadeOutSceneChange : MonoBehaviour
    {
        public GameObject forFadeCanvas;

        [SerializeField]
        private float _alphaValue = 0f;

        [SerializeField]
        private float _fadeSpeed = 0.05f;

        /// <summary>
        /// FadeOut後にシーンチェンジ
        /// </summary>
        /// <param name="sceneName">遷移先のシーンの名前</param>
        public void SceneChange(string sceneName)
        {
            forFadeCanvas.SetActive(true);
            Image forFadePanel = forFadeCanvas.GetComponent<Image>();
            forFadePanel.color = new Color(0, 0, 0, 0);

            StartCoroutine(FadeOutCoroutine(forFadePanel, sceneName));
        }

        IEnumerator FadeOutCoroutine(Image fadePanel, string sceneName)
        {
            while (_alphaValue < 1)
            {
                _alphaValue += _fadeSpeed;
                fadePanel.color = new Color(0, 0, 0, _alphaValue);

                yield return null;
            }
            SceneManager.LoadScene(sceneName);
        }
    }
}