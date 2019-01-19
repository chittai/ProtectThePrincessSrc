using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class EnemyMoving : MonoBehaviour
    {

        private Vector3 _originPosition;
        private Vector3 _destinationPosition;

        private bool _isMoving;

        void Start()
        {
            StartCoroutine("MovingNextPositionCoroutine");
        }

        void Update()
        {
            if (!_isMoving)
                StartCoroutine("MovingNextPositionCoroutine");
        }

        /// <summary>
        /// 敵が次の位置移動する
        /// </summary>
        /// <returns></returns>
        IEnumerator MovingNextPositionCoroutine()
        {
            _isMoving = true;

            float positionX;
            float positionY;

            float movingParameter = 0;

            positionX = Random.Range(-2.0f, 2.0f);
            positionY = Random.Range(0, 3.0f);

            _originPosition = transform.position;
            _destinationPosition = new Vector3(positionX, positionY, transform.position.z);

            while (movingParameter <= 1)
            {
                transform.position = Vector3.Lerp(_originPosition, _destinationPosition, movingParameter);
                yield return null;
                movingParameter += Time.deltaTime;
            }

            yield return new WaitForSeconds(1);

            _isMoving = false;

        }

    }
}