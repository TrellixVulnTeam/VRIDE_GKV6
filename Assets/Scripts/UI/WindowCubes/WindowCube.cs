using UnityEngine;

public class WindowCube : CodeCube
{
    public Transform face1;
    public Transform face2;
    public Transform face3;
    public Transform face4;
    public Transform face5;
    public Transform face6;

    private bool opened = false;

    public override void InnerStart()
    {
        foreach (Canvas c in GetComponentsInChildren<Canvas>())
            c.worldCamera = Camera.main;
    }

    public virtual void OnActivate()
    {
        if (!opened) Open();
        else Close();
    }

    protected void Open()
    {
        transform.rotation = Quaternion.Euler(Vector3.zero);

        MoveLocallyTo(face2, new Vector3(0f, 1f, -.5f), false);
        MoveLocallyTo(face3, new Vector3(0f, -1f, -.5f), false);
        MoveLocallyTo(face4, new Vector3(-1f, 0f, -.5f), false);
        MoveLocallyTo(face5, new Vector3(1f, 0f, -.5f), false);
        MoveLocallyTo(face6, new Vector3(2f, 0f, -.5f), false);

        face2.localRotation = Quaternion.Euler(Vector3.zero);
        face3.localRotation = Quaternion.Euler(Vector3.zero);
        face4.localRotation = Quaternion.Euler(Vector3.zero);
        face5.localRotation = Quaternion.Euler(Vector3.zero);
        face6.localRotation = Quaternion.Euler(Vector3.zero);

        transform.forward = Camera.main.transform.forward;

        opened = true;
    }

    protected void Close()
    {
        transform.rotation = Quaternion.Euler(Vector3.zero);

        MoveLocallyTo(face2, new Vector3(0f, .5f, 0f), false);
        MoveLocallyTo(face3, new Vector3(0f, -.5f, 0f), false);
        MoveLocallyTo(face4, new Vector3(-.5f, 0f, 0f), false);
        MoveLocallyTo(face5, new Vector3(.5f, 0f, 0f), false);
        MoveLocallyTo(face6, new Vector3(0f, 0f, .5f), false);

        face2.localRotation = Quaternion.Euler(90f, 0f, 0f);
        face3.localRotation = Quaternion.Euler(-90f, 0f, 0f);
        face4.localRotation = Quaternion.Euler(0f, 90f, 0f);
        face5.localRotation = Quaternion.Euler(0f, -90f, 0f);
        face6.localRotation = Quaternion.Euler(0f, 180f, 0f);

        transform.forward = Camera.main.transform.forward;

        opened = false;
    }
}
