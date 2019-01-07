﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using VRM;

public class GameOver : GameEndBase
{

    public GameObject gameOverPanel;
    public GameObject gameOverText;

    public override void GameEndDetail()
    {
        gameOverPanel.SetActive(true);
        gameOverText.SetActive(true);
        gameOverPanel.GetComponent<Image>().color = new Color(1,0,0,0.4f);

        //var alicia = GameObject.Find("Model/AliciaSolid");

        alicia.GetComponent<PrincessMoving>().enabled = false;
        alicia.transform.LookAt(new Vector3(alicia.transform.position.x, alicia.transform.position.y, alicia.transform.position.z - 1));
        alicia.GetComponent<VRMBlendShapeProxy>().SetValue(FacialExpressions.Sorrow.ToString(),1);

        GetComponent<WaitForSecondSceneChange>().SceneChange("Result_GameOver_Master");

    }
}