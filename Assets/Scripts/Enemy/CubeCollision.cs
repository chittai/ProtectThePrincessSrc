using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

namespace VRGame
{
    public class CubeCollision : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            var hitObject = collision.gameObject;
            var layername = LayerMask.LayerToName(collision.gameObject.layer);

            // 敵の攻撃が当たった時の"敵の攻撃"の処理
            if (layername == "Chara")
            {
                Destroy(this.gameObject);

                // 敵の攻撃が当たった時にキャラクターの向きを正面にかえる
                hitObject.transform.LookAt(new Vector3(hitObject.transform.position.x, hitObject.transform.position.y, hitObject.transform.position.z - 1));

                // キャラクターの動きを止める
                var princessMoving = hitObject.GetComponent<PrincessMoving>();
                princessMoving.movingStatus = true;
                princessMoving.runningStatus = true;

                // キャラクターの表情を変える
                var proxy = hitObject.GetComponent<VRMBlendShapeProxy>();
                proxy.SetValue(FacialExpressions.Sorrow.ToString(), 1);
                hitObject.GetComponent<PlaySoundEffect>().Sound();
                hitObject.transform.GetChild(9).GetComponent<HpDecreasing>().BreakHeart();
            }
        }
    }
}