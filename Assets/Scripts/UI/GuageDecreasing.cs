using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuageDecreasing : MonoBehaviour {

    public GameObject rightGuage;
    public GameObject leftGuage;
    private GameObject _guage;

    private float guageMax;
    private float width;

    private float guageNow;
    public float restGuage{ get { return guageNow; } set { guageNow = value; } }

    private OVRInput.Controller preGuage;

    private OVRInput.Controller controller;
    
    void Start()
    {
        guageMax = Mathf.Clamp(guageNow, 0, guageMax);
        guageMax = 5;
        guageNow = guageMax;
        width = 1150;
    }

    void Update()
    {
        controller = OVRInput.GetActiveController();

        if (controller == OVRInput.Controller.RTrackedRemote)
        {
            _guage = rightGuage;

            // 利き腕を変更した時に、今ま減少したゲージの長さを変更後にも反映させる
            if (preGuage == OVRInput.Controller.LTrackedRemote)
            {
                GuageShapeChange();
            }
            preGuage = controller;
        }
        else if(controller == OVRInput.Controller.LTrackedRemote)
        {
            _guage = leftGuage;
            if (preGuage == OVRInput.Controller.RTrackedRemote)
            {
                GuageShapeChange();
            }
            preGuage = controller;
        }
    }

    /// <summary>
    /// ゲージの長さを変更する
    /// </summary>
    public void Decreasing()
    {
        guageNow -= Time.deltaTime;
        GuageShapeChange();
    }

    /// <summary>
    /// ゲージの長さを guageNow / guageMax の割合にする
    /// </summary>
    private void GuageShapeChange()
    {
        _guage.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (guageNow / guageMax), _guage.GetComponent<RectTransform>().sizeDelta.y);
    }

}
