using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

namespace VRGame
{
    public class DisplayProfiler : MonoBehaviour
    {
        void Start()
        {
            Profiler.AddFramesFromFile("perfomance.log");
        }
    }
}