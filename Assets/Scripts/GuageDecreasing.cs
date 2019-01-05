using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuageDecreasing : MonoBehaviour {

    public GameObject rightGuage;
    public GameObject leftGuage;
    private GameObject guage;

    private float guageMax;
    private float guageNow;
    private float width;
    public float restGuage{ get { return guageNow; } set { guageNow = value; } }

    private OVRInput.Controller preGuage;

    // Use this for initialization
    void Start () {
        guageMax = Mathf.Clamp(guageNow,0, guageMax);
        guageMax = 5;
        guageNow = guageMax;
        //isRestGuage = true;
        width = 1150;
    }

    void Update()
    {
        var controller = OVRInput.GetActiveController();

        if (controller == OVRInput.Controller.RTrackedRemote)
        {
            guage = rightGuage;
            if (preGuage == OVRInput.Controller.LTrackedRemote)
            {
                guage.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (guageNow / guageMax), guage.GetComponent<RectTransform>().sizeDelta.y);
            }
            preGuage = controller;
        }
        else if(controller == OVRInput.Controller.LTrackedRemote)
        {
            guage = leftGuage;
            if (preGuage == OVRInput.Controller.RTrackedRemote)
            {
                guage.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (guageNow / guageMax), guage.GetComponent<RectTransform>().sizeDelta.y);
            }
            preGuage = controller;
        }
    }

    public void Decreasing()
    {
        guageNow -= Time.deltaTime;
        guage.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (guageNow/ guageMax), guage.GetComponent<RectTransform>().sizeDelta.y);
    }
}
