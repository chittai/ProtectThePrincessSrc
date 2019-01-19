using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VRGame
{
    public class WaitForSecondSceneChange : MonoBehaviour
    {

        [SerializeField]
        private int _second = 4;

        /// <summary>
        /// 指定した秒数後にシーンチェンジする
        /// </summary>
        /// <param name="sceneName">遷移先のシーン名</param>
        public void SceneChange(string sceneName)
        {
            StartCoroutine(WaitForSecondCoroutine(sceneName));
        }

        IEnumerator WaitForSecondCoroutine(string sceneName)
        {
            for (int i = 0; i < _second; i++)
            {
                yield return new WaitForSeconds(1);
            }
            SceneManager.LoadScene(sceneName);
        }
    }
}