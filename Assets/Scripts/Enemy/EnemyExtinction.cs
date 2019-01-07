using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExtinction : MonoBehaviour {

    public GameObject enemyGroup;
    public GameObject extinctionParticle;

    void Update()
    {
        // for Debug
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Extinction();
        }
        */
    }

    /// <summary>
    /// 配置している敵のオブジェクトをDestroyする。消える演出として同時にパーティクルの生成をする
    /// </summary>
    public void Extinction()
    {
        foreach (Transform enemy in enemyGroup.transform)
        {
            Destroy(enemy.gameObject);
            Instantiate(extinctionParticle, enemy.transform.position, enemy.transform.rotation);
        } 
    }

}
