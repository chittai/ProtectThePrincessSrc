using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour {

    private Vector3 originPosition;
    private Vector3 destinationPosition;

    private bool isMoving;

    void Start () {
        StartCoroutine("MovingNextPositionCoroutine");	
	}

	void Update () {
        if (!isMoving)
            StartCoroutine("MovingNextPositionCoroutine");
	}

    /// <summary>
    /// 敵が次の位置移動する
    /// </summary>
    /// <returns></returns>
    IEnumerator MovingNextPositionCoroutine()
    {
        isMoving = true;

        float positionX;
        float positionY;

        float movingParameter = 0;

        positionX = Random.Range(-2.0f,2.0f);
        positionY = Random.Range(0, 3.0f);

        originPosition = transform.position;
        destinationPosition = new Vector3(positionX, positionY,transform.position.z);

        while (movingParameter <= 1)
        {
            transform.position = Vector3.Lerp(originPosition, destinationPosition, movingParameter);
            yield return null;
            movingParameter += Time.deltaTime;
        }

        yield return new WaitForSeconds(1);

        isMoving = false;

    }

}
