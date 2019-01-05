using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class CollisionDetermination : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        string layername = LayerMask.LayerToName(collision.gameObject.layer);
        string mylayername = LayerMask.LayerToName(this.gameObject.layer);

        if (layername == "Chara")
        {
            Destroy(this.gameObject);
        }

        if (layername == "EnemyAttack")
        {
            transform.LookAt(new Vector3(transform.position.x, transform.position.y, transform.position.z - 1 ));
            var princessMoving = GetComponent<PrincessMoving>();
            princessMoving.movingStatus = true;
            princessMoving.runningStatus = false;
            var proxy = GetComponent<VRMBlendShapeProxy>();
            proxy.SetValue("Sorrow", 1);

            GetComponent<PlaySoundEffect>().Sound();

            this.transform.GetChild(9).GetComponent<HpDecreasing>().BreakHeart();

        }
    }
}
