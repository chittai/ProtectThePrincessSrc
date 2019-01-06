using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class PrincessMoving : MonoBehaviour
{

    private bool isMoving;
    public bool movingStatus
    {
        get { return isMoving; }
        set { isMoving = value; }
    }

    private bool isArrivedDestination;
    public bool runningStatus
    {
        get { return isArrivedDestination; }
        set { isArrivedDestination = value; }
    }

    private Vector3 origin;
    private Vector3 destination;
    private float time;
    private Animator animator;
    private VRMBlendShapeProxy proxy;
    private float origin_x;
    private float destination_x;

    private IEnumerator runningCoroutine;

    void Start()
    {
        isMoving = false;
        animator = GetComponent<Animator>();
        isArrivedDestination = false;
        destination_x = 0;
        proxy = GetComponent<VRMBlendShapeProxy>();
        proxy.SetValue(FacialExpressions.Puzzle.ToString(), 1);
    }

    void Update()
    {

        if (isMoving && isArrivedDestination)
        {
            StopRunning();
        }

        if (!isMoving)
        {
            time += Time.deltaTime;
            proxy.SetValue(FacialExpressions.Puzzle.ToString(), 1);

            if (time > 3.0f)
            {
                StartRunning();
            }
        }
    }

    private void StartRunning()
    {

        proxy.SetValue(FacialExpressions.Srrow.ToString(), 0);
        isMoving = true;
        origin = transform.position;
        destination_x = Random.Range(-2.0f, 2.0f);
        destination = new Vector3(destination_x, transform.position.y, transform.position.z);
        time = 0;
        if (destination_x > origin_x)
        {
            transform.Rotate(0, -90, 0);
        }
        else
        {
            transform.Rotate(0, 90, 0);
        }
        animator.SetBool("isRunning", true);

        Running();
    }

    public void StopRunning()
    {
        animator.SetBool("isRunning", false);
        if (runningCoroutine != null) StopCoroutine(runningCoroutine);
        origin_x = destination_x;
        transform.LookAt(new Vector3(transform.position.x, transform.position.y, transform.position.z - 1));
        proxy.SetValue(FacialExpressions.Embarrassed.ToString(), 0);

        isMoving = false;
        isArrivedDestination = false;
    }

    private void Running()
    {
        runningCoroutine = RunningCroutine();
        StartCoroutine(runningCoroutine);
    }

    IEnumerator RunningCroutine()
    {
        float movingParameter = 0;

        movingParameter = Mathf.Clamp01(movingParameter);

        while (movingParameter <= 1)
        {
            transform.position = Vector3.Lerp(origin, destination, movingParameter);
            yield return null;
            movingParameter += Time.deltaTime;
            proxy.SetValue(FacialExpressions.Embarrassed.ToString(), 1.0f);
        }

        isArrivedDestination = true;

    }
}
