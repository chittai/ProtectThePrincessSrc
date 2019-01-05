using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class OutputProfiler : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        Profiler.logFile = "perfomance.log";
        Profiler.enableBinaryLog = true;
        Profiler.enabled = true;
	}

    private void OnDestroy()
    {
        // 無効化
        Profiler.logFile = "";
        Profiler.enabled = false;
    }

    private void OnApplicationQuit()
    {
        // 無効化
        Profiler.logFile = "";
        Profiler.enabled = false;
    }
}
