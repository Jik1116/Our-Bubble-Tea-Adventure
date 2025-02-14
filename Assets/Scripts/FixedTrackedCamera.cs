using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private Transform trackedObject;

    public Vector3 offset;
    public Vector3 allowance;
    public bool trackX;
    public bool trackY;

    [Header("Debug")]
    public bool showCamera;
    public bool showTracked;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = CalculateCameraPos();
    }

    Vector3 CalculateCameraPos()
    {
        Vector3 currentPos = transform.position;
        Vector3 newPos = trackedObject.position + offset;
        Vector3 diff = newPos - currentPos;
        if (trackX && Math.Abs(diff.x) >= allowance.x) currentPos.x = newPos.x;
        if (trackY && Math.Abs(diff.y) >= allowance.y) currentPos.y = newPos.y;
        return currentPos;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow * new Vector4(1, 1, 1, 0.4f);
        Vector3 trackedPos = CalculateCameraPos();
        trackedPos.z = 0.0f;
        if (showCamera) Gizmos.DrawCube(trackedPos, Vector3.one);
        Vector3 trackedObjectPos = trackedObject.position;
        if (trackX) trackedObjectPos.x = trackedPos.x - offset.x;
        if (trackY) trackedObjectPos.y = trackedPos.y - offset.y;
        if (showTracked) Gizmos.DrawCube(trackedObjectPos, Vector3.one);
    }
}
