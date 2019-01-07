using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class DisplayProfiler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Profiler.AddFramesFromFile("perfomance.log");
	}
}
