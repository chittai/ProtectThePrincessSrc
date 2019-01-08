using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class OptimizationForPerformance : MonoBehaviour
    {
        void Start()
        {
            OVRManager.tiledMultiResLevel = OVRManager.TiledMultiResLevel.LMSHigh;
        }
    }
}