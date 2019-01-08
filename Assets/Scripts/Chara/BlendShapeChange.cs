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

        private VRMBlendShapeProxy proxy;
        public bool clearFlag;

        private void Start()
        {
            proxy = GetComponent<VRMBlendShapeProxy>();

            if (clearFlag)
            {
                proxy.SetValue(FacialExpressions.Joy.ToString(), 1.0f);
            }
            else if (!clearFlag)
            {
                proxy.SetValue(FacialExpressions.VerySorrow.ToString(), 1.0f);
            }
        }
    }
}
