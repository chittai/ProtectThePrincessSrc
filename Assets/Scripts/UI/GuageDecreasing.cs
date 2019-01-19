using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class GuageDecreasing : MonoBehaviour
    {

        public GameObject rightGuage;
        public GameObject leftGuage;
        private GameObject _guage;
        
        private float _guageMax;
        private float _width;

        private float _guageNow;
        public float restGuage { get { return _guageNow; } set { _guageNow = value; } }

        private OVRInput.Controller _preGuage;
        private OVRInput.Controller _controller;

        void Start()
        {
            _guageMax = Mathf.Clamp(_guageNow, 0, _guageMax);
            _guageMax = 5;
            _guageNow = _guageMax;
            _width = 1150;
        }

        void Update()
        {
            _controller = OVRInput.GetActiveController();

            if (_controller == OVRInput.Controller.RTrackedRemote)
            {
                // 利き腕を変更した時に、今ま減少したゲージの長さを変更後にも反映させる
                if (_preGuage == OVRInput.Controller.LTrackedRemote)
                {
                    GuageShapeChange();
                }
                _preGuage = _controller;
            }
            else if (_controller == OVRInput.Controller.LTrackedRemote)
            {
                _guage = leftGuage;
                if (_preGuage == OVRInput.Controller.RTrackedRemote)
                {
                    GuageShapeChange();
                }
                _preGuage = _controller;
            }
        }

        /// <summary>
        /// ゲージの長さを変更する
        /// </summary>
        public void Decreasing()
        {
            _guageNow -= Time.deltaTime;
            GuageShapeChange();
        }

        /// <summary>
        /// ゲージの長さを guageNow / guageMax の割合にする
        /// </summary>
        private void GuageShapeChange()
        {
            _guage.GetComponent<RectTransform>().sizeDelta = new Vector2(_width * (_guageNow / _guageMax), _guage.GetComponent<RectTransform>().sizeDelta.y);
        }

    }
}
