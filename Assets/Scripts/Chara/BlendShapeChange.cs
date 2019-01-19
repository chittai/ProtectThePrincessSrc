using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

namespace VRGame
{
    /// <summary>
    /// リザルト画面にいるキャラクターの表情を変更する
    /// </summary>
    public class BlendShapeChange : MonoBehaviour
    {

        private VRMBlendShapeProxy _blendShapeProxy;
        public bool clearFlag;

        private void Start()
        {
            _blendShapeProxy = GetComponent<VRMBlendShapeProxy>();
        }

        private void Update()
        {
            if (clearFlag)
            {
                _blendShapeProxy.SetValue(FacialExpressions.Joy.ToString(), 1.0f);
            }
            else if (!clearFlag)
            {
                _blendShapeProxy.SetValue(FacialExpressions.VerySorrow.ToString(), 1.0f);
            }
        }

    }
}
