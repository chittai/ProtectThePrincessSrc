using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class CollisionDetermination : MonoBehaviour {

    /// <summary>
    /// 各種当たり判定用を行う
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        string layername = LayerMask.LayerToName(collision.gameObject.layer);
        string mylayername = LayerMask.LayerToName(this.gameObject.layer);

        // 敵の攻撃が当たった時の"敵の攻撃"の処理
        if (layername == "Chara")
        {
            Destroy(this.gameObject);
        }

        // 敵の攻撃が当たった時の"キャラクター側"の処理
        if (layername == "EnemyAttack")
        {
            transform.LookAt(new Vector3(transform.position.x, transform.position.y, transform.position.z - 1 ));

            // キャラクターの動きを止める
            var princessMoving = GetComponent<PrincessMoving>();
            princessMoving.movingStatus = true;
            princessMoving.runningStatus = true;

            var proxy = GetComponent<VRMBlendShapeProxy>();
            proxy.SetValue(FacialExpressions.Sorrow.ToString(), 1);
            GetComponent<PlaySoundEffect>().Sound();
            this.transform.GetChild(9).GetComponent<HpDecreasing>().BreakHeart();

        }
    }
}
