using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

namespace VRGame
{
    public class PrincessMoving : MonoBehaviour
    {
        /// <value> 走っているかどうか </value>
        private bool isMoving;
        public bool movingStatus
        {
            get { return isMoving; }
            set { isMoving = value; }
        }

        /// <value> 目的地に到着したかどうか。ダメージを受けて停止しても目的地についたと判断する </value>
        private bool isArrivedDestination;
        public bool runningStatus
        {
            get { return isArrivedDestination; }
            set { isArrivedDestination = value; }
        }

        private float _originX;
        private float _destinationX;

        private float _time;

        private Animator _animator;
        private VRMBlendShapeProxy _blendShapeProxy;

        private IEnumerator runningCoroutine;

        void Start()
        {
            isMoving = false;
            _animator = GetComponent<Animator>();
            isArrivedDestination = false;
            _destinationX = 0;
            _blendShapeProxy = GetComponent<VRMBlendShapeProxy>();
            _blendShapeProxy.SetValue(FacialExpressions.Puzzle.ToString(), 1);
        }

        void Update()
        {
            if (isMoving && isArrivedDestination)
            {
                StopRunning();
            }

            if (!isMoving)
            {
                _time += Time.deltaTime;
                _blendShapeProxy.SetValue(FacialExpressions.Puzzle.ToString(), 1);

                if (_time > 3.0f)
                {
                    StartRunning();
                }
            }
        }

        /// <summary>
        /// 次の目的地を計算し、その座標までキャラクターを走らせる処理
        /// </summary>
        private void StartRunning()
        {
            _blendShapeProxy.SetValue(FacialExpressions.Sorrow.ToString(), 0);
            isMoving = true;
            _time = 0;

            _destinationX = Random.Range(-2.0f, 2.0f);
            if (_destinationX > _originX)
            {
                transform.Rotate(0, -90, 0);
            }
            else
            {
                transform.Rotate(0, 90, 0);
            }

            _animator.SetBool("isRunning", true);
            runningCoroutine = RunningCroutine();
            StartCoroutine(runningCoroutine);
        }

        IEnumerator RunningCroutine()
        {
            float movingParameter = 0;

            movingParameter = Mathf.Clamp01(movingParameter);

            var origin = transform.position;
            var destination = new Vector3(_destinationX, transform.position.y, transform.position.z);
            _blendShapeProxy.SetValue(FacialExpressions.Embarrassed.ToString(), 1.0f);

            while (movingParameter <= 1)
            {
                transform.position = Vector3.Lerp(origin, destination, movingParameter);
                yield return null;
                movingParameter += Time.deltaTime;
            }

            isArrivedDestination = true;

        }

        /// <summary>
        /// 走っているキャラクターを停止
        /// </summary>
        public void StopRunning()
        {
            _animator.SetBool("isRunning", false);

            if (runningCoroutine != null)
                StopCoroutine(runningCoroutine);

            _originX = transform.position.x;

            transform.LookAt(new Vector3(transform.position.x, transform.position.y, transform.position.z - 1));
            _blendShapeProxy.SetValue(FacialExpressions.Embarrassed.ToString(), 0);

            isMoving = false;
            isArrivedDestination = false;
        }
    }
}