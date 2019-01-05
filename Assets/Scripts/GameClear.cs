using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using VRM;

public class GameClear : MonoBehaviour {

    public GameObject gameClearPanel;
    public GameObject gameClearText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameClearDetail()
    {
        gameClearPanel.SetActive(true);
        gameClearText.SetActive(true);
        gameClearPanel.GetComponent<Image>().color = new Color(255, 255, 255, 0.4f);

        //var alicia = GameObject.Find("Model/AliciaSolid");
        var alicia = GameObject.Find("Model/VRoid_test");

        alicia.GetComponent<PrincessMoving>().enabled = false;
        alicia.transform.LookAt(new Vector3(alicia.transform.position.x, alicia.transform.position.y, alicia.transform.position.z - 1));
        alicia.GetComponent<VRMBlendShapeProxy>().SetValue("Fun", 1);

        GetComponent<EnemyExtinction>().Extinction();

        StartCoroutine("LoadSceneCoroutine");

    }

    IEnumerator LoadSceneCoroutine()
    {
        int time = 4;
        for (int i = 0; i < time; i++)
        {
            yield return new WaitForSeconds(1);
        }

        SceneManager.LoadScene("Result_GameClear_Master");
    }


}
