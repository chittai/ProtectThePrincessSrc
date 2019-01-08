using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using VRM;

namespace VRGame
{
    public class GameClear : GameEndBase
    {
        public GameObject gameClearPanel;
        public GameObject gameClearText;

        /// <summary>
        /// クリア時の処理。キャラの向きを変え、表情を変え、敵のオブジェクトを消す
        /// </summary>
        public override void GameEndDetail()
        {
            gameClearPanel.SetActive(true);
            gameClearText.SetActive(true);
            gameClearPanel.GetComponent<Image>().color = new Color(255, 255, 255, 0.4f);

            alicia.GetComponent<PrincessMoving>().enabled = false;
            alicia.transform.LookAt(new Vector3(alicia.transform.position.x, alicia.transform.position.y, alicia.transform.position.z - 1));
            alicia.GetComponent<VRMBlendShapeProxy>().SetValue(FacialExpressions.Fun.ToString(), 1);

            GetComponent<EnemyExtinction>().Extinction();
            GetComponent<WaitForSecondSceneChange>().SceneChange("Result_GameClear_Master");
        }
    }
}