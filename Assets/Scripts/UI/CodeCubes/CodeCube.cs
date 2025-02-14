using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CodeCube : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 1000f;
    public float scalingSpeed = 5f;

    private Transform baseParent;
    protected bool isDragged = false;

    protected VRIDEInputHandler playerInputs;
  
    void Start()
    {
        GetComponent<XRSimpleInteractable>().interactionManager = 
            GameObject.Find("XR Interaction Manager").GetComponent<XRInteractionManager>();

        InnerStart();

        //StartCoroutine(PositionLogCorountine());
    }

    void Update()
    {
        if (isDragged)
        {
            VRIDEInputHandler inputs = transform.parent.root.GetComponent<VRIDEInputHandler>();
            if (inputs.LeftPrimaryButtonDown || inputs.RightPrimaryButtonDown)
                Destroy(gameObject);
            else if (inputs.LeftAxisLeft || inputs.RightAxisLeft)
                transform.Rotate(0f, -100f * Time.deltaTime, 0f, Space.World);
            else if(inputs.LeftAxisRight || inputs.RightAxisRight)
                transform.Rotate(0f, 100f * Time.deltaTime, 0f, Space.World);
            else if (inputs.LeftAxisUp || inputs.RightAxisUp)
                transform.Rotate(-100f * Time.deltaTime, 0f, 0f, Space.World);
            else if (inputs.LeftAxisDown || inputs.RightAxisDown)
                transform.Rotate(100f * Time.deltaTime, 0f, 0f, Space.World);
        }
    }

    public virtual void InnerStart()
    {
        
    }

    public void RotateLocally(float degrees)
    {
        StartCoroutine(RotateLocallyBy(degrees));
    }

    public void MoveTo(Transform t, Vector3 target, bool shouldDestroy)
    {
        StartCoroutine(MoveToTarget(t, target, shouldDestroy));
    }

    public void MoveLocallyTo(Transform t, Vector3 target, bool shouldDestroy)
    {
        StartCoroutine(MoveLocallyToTarget(t, target, shouldDestroy));
    }

    public void ScaleTo(Vector3 target)
    {
        StartCoroutine(ScaleBy(target));
    }

    protected IEnumerator MoveToTarget(Transform t, Vector3 target, bool shouldDestroy)
    {
        while (t.position != target)
        {
            t.position = Vector3.MoveTowards(
                t.position, target, Time.deltaTime * movementSpeed
            );

            yield return null;
        }

        if (shouldDestroy) Destroy(t.gameObject);
    }

    protected IEnumerator MoveLocallyToTarget(Transform t, Vector3 target, bool shouldDestroy)
    {
        while (t.localPosition != target)
        {
            t.localPosition = Vector3.MoveTowards(
                t.localPosition, target, Time.deltaTime * movementSpeed
            );

            yield return null;
        }

        if (shouldDestroy) Destroy(t.gameObject);
    }

    protected IEnumerator RotateLocallyBy(float degrees)
    {
        float degreeCounter = 0f;
        while(Mathf.Abs(degreeCounter) <= Mathf.Abs(degrees))
        {
            float degreesRotated = rotationSpeed * Time.deltaTime;
            transform.Rotate(0f, degreesRotated, 0f);
            degreeCounter += degreesRotated;
            yield return null;
        }
    }

    protected IEnumerator ScaleBy(Vector3 target)
    {
        while (transform.localScale != target)
        {
            transform.localScale = Vector3.MoveTowards(
                transform.localScale, target, Time.deltaTime * scalingSpeed
            );

            yield return null;
        }
    }

    public virtual void OnSelectEnter(SelectEnterEventArgs eventArgs)
    {
        isDragged = true;
        baseParent = transform.parent;
        transform.SetParent(eventArgs.interactor.transform);
        playerInputs = transform.parent.root.GetComponent<VRIDEInputHandler>();
    }

    public virtual void OnSelectExit()
    {
        isDragged = false;
        transform.SetParent(null);
        playerInputs = null;

        foreach (Canvas c in GetComponentsInChildren<Canvas>())
        {
            c.enabled = false;
            c.enabled = true;
        }
    }

    /**
    IEnumerator PositionLogCorountine()
    {
        int time = 0;
        string logFile = Path.Combine(Application.persistentDataPath, gameObject.GetInstanceID() + ".csv");

        if (File.Exists(logFile))
            File.Delete(logFile);
        File.AppendAllText(logFile, "X,Y,Z,Time\n");

        while (true)
        {
            File.AppendAllText(logFile,
                transform.position.x.ToString().Replace(",", ".") + "," +
                transform.position.y.ToString().Replace(",", ".") + "," +
                transform.position.z.ToString().Replace(",", ".") + "," + time + "\n");

            time++;
            yield return new WaitForSeconds(1);
        }
    }
    **/
}
