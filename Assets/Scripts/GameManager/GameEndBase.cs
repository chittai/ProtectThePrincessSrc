using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public abstract class GameEndBase : MonoBehaviour
    {
        public abstract void GameEndDetail();

        protected GameObject alicia
        {
            get
            {
                return GameObject.Find("Model/AliciaSolid");
            }
        }
    }
}