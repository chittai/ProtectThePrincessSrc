using UnityEngine;
using Oculus.Platform;

public class AppEntitlementCheck : MonoBehaviour {

    /// <summary>
    /// Entitlement Check 用のスクリプト
    /// </summary>

    void Awake()
    {
        Core.AsyncInitialize();
        Entitlements.IsUserEntitledToApplication().OnComplete(
            (Message msg) =>
            {
                if (msg.IsError)
                {
                    print("Not Entitled");
                    UnityEngine.Application.Quit();
                }
                else
                {
                    print("EntilementCheck Passed");
                }
            }
       );
    }
}
